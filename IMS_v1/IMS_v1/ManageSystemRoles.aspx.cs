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
    public partial class ManageSystemRoles : System.Web.UI.Page
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
            ds = SystemRoleBLL.GetAllSystemRoles();
            roleDepGrid.DataSource = ds;
            roleDepGrid.DataBind();
        }

        protected void roleDepGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            roleDepGrid.EditIndex = -1;
            BindGrid();
        }

        protected void roleDepGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            roleDepGrid.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void roleDepGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Add"))
                {
                    SystemRoleBLL sRoleManager = new SystemRoleBLL();
                    TextBox txtname = (TextBox)roleDepGrid.FooterRow.FindControl("txtAddname");


                    SystemRoles roleToAdd = new SystemRoles();
                    roleToAdd.RoleName = txtname.Text;
                   

                    sRoleManager.Add(roleToAdd);


                }
            }
            catch (Exception exp) { }
            finally
            {
                roleDepGrid.EditIndex = -1;
                BindGrid();
            }
        }

        protected void roleDepGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                SystemRoleBLL sRoleManager = new SystemRoleBLL();
                Label ID = (Label)roleDepGrid.Rows[e.RowIndex].FindControl("lblRole_ID");
                int selectedId = int.Parse(ID.Text);
                SystemRoles roleToDelete = new SystemRoles();//= empid.Text;
                roleToDelete.RoleID = selectedId;
                sRoleManager.Delete(roleToDelete);


            }
            catch (Exception exp) { }
            finally
            {
                roleDepGrid.EditIndex = -1;
                BindGrid();
            }
        }

        protected void roleDepGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            roleDepGrid.EditIndex = e.NewEditIndex;
        }

        protected void roleDepGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void roleDepGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}