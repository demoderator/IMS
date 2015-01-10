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
    public partial class ManageDepartment : System.Web.UI.Page
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

        protected void ViewDepartment_Click(object sender, EventArgs e)
        {
        
           
        }

        protected void DepDisplayGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DepDisplayGrid.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        
        protected void DepDisplayGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DepDisplayGrid.EditIndex = -1;
            BindGrid();
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

                DepDisplayGrid.EditIndex = -1;
                BindGrid();
            }
            catch (Exception exp) { }
        }

        protected void DepDisplayGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DepartmentBLL depManager = new DepartmentBLL();
            Label id = (Label)DepDisplayGrid.Rows[e.RowIndex].FindControl("lblDep_Id");
            TextBox name = (TextBox)DepDisplayGrid.Rows[e.RowIndex].FindControl("txtname");
            TextBox code = (TextBox)DepDisplayGrid.Rows[e.RowIndex].FindControl("txtCode");
          
            int selectedId=int.Parse(id.Text);
            Department depToUpdate = new Department();//= empid.Text;
            depToUpdate.DepartmentID = selectedId;
            depToUpdate.Name = name.Text;
            depToUpdate.Code = code.Text;
            depManager.Update( depToUpdate);
          
            DepDisplayGrid.EditIndex = -1;
            BindGrid();
        }

        protected void DepDisplayGrid_RowCommand(object sender, GridViewCommandEventArgs e)
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

                DepDisplayGrid.EditIndex = -1;
                BindGrid();
            }
            
        }

        protected void DepDisplayGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DepDisplayGrid.EditIndex = e.NewEditIndex;
            BindGrid();
        }
        private void BindGrid()
        {
            ds = DepartmentBLL.GetAllDepartment();
            DepDisplayGrid.DataSource = ds;
            DepDisplayGrid.DataBind();
        }
    }
}