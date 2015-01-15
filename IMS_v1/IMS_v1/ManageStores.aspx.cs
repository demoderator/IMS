using IMSBusinessLogic;
using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class ManageStores : System.Web.UI.Page
    {
        private DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                    BindGrid();
                }
                catch (Exception exp) { }
            }
        }

        private void BindGrid()
        {
            ds = UserRoleBLL.GetAllUserRoles();
            storeDepGrid.DataSource = ds;
            storeDepGrid.DataBind();

            DropDownList depList = (DropDownList)storeDepGrid.FooterRow.FindControl("ddlAddRoleName");
            depList.DataSource = SystemRoleBLL.GetAllSystemRoles();
            depList.DataBind();
            depList.DataTextField = "RoleName";
            depList.DataValueField = "RoleId";
            depList.DataBind();
        }

        protected void storeDepGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            storeDepGrid.EditIndex = -1;
            BindGrid();
        }

        protected void storeDepGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            storeDepGrid.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void storeDepGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Add"))
                {
                    UserRoleBLL sRoleManager = new UserRoleBLL();
                    TextBox txtname = (TextBox)storeDepGrid.FooterRow.FindControl("txtAddname");
                    TextBox txtDesc = (TextBox)storeDepGrid.FooterRow.FindControl("txtAddRDesc");
                    string roleName = (storeDepGrid.FooterRow.FindControl("ddlAddRoleName") as DropDownList).SelectedItem.Value;

                    UserRoles roleToAdd = new UserRoles();
                    roleToAdd.UserRoleName = txtname.Text;
                    roleToAdd.Description = txtDesc.Text;
                    int res;
                    if (int.TryParse(roleName, out res))
                    {
                        roleToAdd.SystemRoleId = res;
                        sRoleManager.Add(roleToAdd);

                    }
                }
            }
            catch (Exception exp) { }
            finally
            {
                storeDepGrid.EditIndex = -1;
                BindGrid();
            }
        }

        protected void storeDepGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                UserRoleBLL sRoleManager = new UserRoleBLL();
                Label ID = (Label)storeDepGrid.Rows[e.RowIndex].FindControl("lblUserRole_ID");
                int selectedId = int.Parse(ID.Text);
                UserRoles roleToDelete = new UserRoles();//= empid.Text;
                roleToDelete.UserRoleId = selectedId;
                sRoleManager.Delete(roleToDelete);


            }
            catch (Exception exp) { }
            finally
            {
                storeDepGrid.EditIndex = -1;
                BindGrid();
            }
        }

        protected void storeDepGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            storeDepGrid.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void storeDepGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void storeDepGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    try
                    {
                        DropDownList depList = (DropDownList)e.Row.FindControl("ddlRoleName");
                        depList.DataSource = SystemRoleBLL.GetAllSystemRoles();
                        depList.DataBind();
                        depList.DataTextField = "RoleName";
                        depList.DataValueField = "RoleId";
                        depList.DataBind();
                       // depList.Items.FindByValue((e.Row.FindControl("lblDep_Id") as Label).Text).Selected = true;

                        DataRowView dr = e.Row.DataItem as DataRowView;
                        depList.SelectedValue = (string)e.Row.DataItem; // you can use e.Row.DataItem to get the value
                    }
                    catch (Exception exo)
                    { }
                }
            }
        }
    }
}