using IMSBusinessLogic;
using IMSCommon;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class ManageDepartment : System.Web.UI.Page
    {
        private DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                    BindGrid(false);
                    BindDropSearch();
                }
                catch (Exception exp) { }
            }
        }

        protected void ViewDepartment_Click(object sender, EventArgs e)
        {


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BindGrid(true);
        }
        protected void DepDisplayGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DepDisplayGrid.PageIndex = e.NewPageIndex;
            BindGrid(false);
        }

        protected void DepDisplayGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DepDisplayGrid.EditIndex = -1;
            BindGrid(false);
        }

        protected void DepDisplayGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                DepartmentBLL depManager = new DepartmentBLL();
                Label ID = (Label)DepDisplayGrid.Rows[e.RowIndex].FindControl("lblDep_ID");
                int selectedId = int.Parse(ID.Text);
                Department depToDelete = new Department();//= empid.Text;
                depToDelete.DepartmentID = selectedId;
                depManager.Delete(depToDelete);


            }
            catch (Exception exp) { }
            finally
            {
                DepDisplayGrid.EditIndex = -1;
                BindGrid(false);
            }
        }

        //protected void DepDisplayGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
           
        //}

        protected void DepDisplayGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Add"))
                {
                    DepartmentBLL depManager = new DepartmentBLL();
                    TextBox txtname = (TextBox)DepDisplayGrid.FooterRow.FindControl("txtAddname");
                    TextBox txtCode = (TextBox)DepDisplayGrid.FooterRow.FindControl("txtAddCode");

                    Department depToAdd = new Department();
                    depToAdd.Name = txtname.Text;
                    depToAdd.Code = txtCode.Text;

                    depManager.Add(depToAdd);


                }
                else if (e.CommandName.Equals("UpdateDep"))
                {

                    DepartmentBLL depManager = new DepartmentBLL();
                    GridViewRow row = DepDisplayGrid.Rows[DepDisplayGrid.EditIndex];
                    Label id = (Label)row.FindControl("lblDep_Id");
                    TextBox name = (TextBox)DepDisplayGrid.Rows[DepDisplayGrid.EditIndex].Cells[0].FindControl("txtname");
                    TextBox code = (TextBox)DepDisplayGrid.Rows[DepDisplayGrid.EditIndex].FindControl("txtCode");

                    int selectedId = int.Parse(id.Text);
                    Department depToUpdate = new Department();//= empid.Text;
                    depToUpdate.DepartmentID = selectedId;
                    depToUpdate.Name = name.Text;
                    depToUpdate.Code = code.Text;
                    depManager.Update(depToUpdate);
                }
            }
            catch (Exception exp) { }
            finally
            {
                DepDisplayGrid.EditIndex = -1;
                BindGrid(false);
            }

        }

        protected void DepDisplayGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DepDisplayGrid.EditIndex = e.NewEditIndex;
           // BindGrid();
        }
        private void BindGrid(bool isSearch)
        {
            if (ddlDepName.SelectedIndex != -1 && isSearch)
            {
                Department obj = new Department();
                obj.DepartmentID = int.Parse(ddlDepName.SelectedValue);
                DepartmentBLL depBll = new DepartmentBLL();
                ds= depBll.GetById(obj);
            }
            else
            {
                ds = DepartmentBLL.GetAllDepartment();
               
            }
            DepDisplayGrid.DataSource = ds;
            DepDisplayGrid.DataBind();
        }

        private void BindDropSearch()
        {

            ddlDepName.DataSource = DepartmentBLL.GetAllDepartment();
            ddlDepName.Items.Insert(0, new ListItem("Select Department", ""));
            ddlDepName.DataTextField = "Name";
            ddlDepName.DataValueField = "DepId";

            ddlDepName.DataBind();
        }
    }
}