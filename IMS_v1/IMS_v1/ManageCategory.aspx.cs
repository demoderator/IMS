using IMSBusinessLogic;
using IMSCommon;
using IMSCommon.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class ManageCategory : System.Web.UI.Page
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

        protected void CategoryDisplayGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CategoryDisplayGrid.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void CategoryDisplayGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            CategoryDisplayGrid.EditIndex = -1;
            BindGrid();
        }

        protected void CategoryDisplayGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Add"))
                {
                    CategoryBLL categoryManager = new CategoryBLL();
                    TextBox txtname = (TextBox)CategoryDisplayGrid.FooterRow.FindControl("txtAddname");
                    TextBox txtDepId = (TextBox)CategoryDisplayGrid.FooterRow.FindControl("txtAddDepID");

                    Category categoryToAdd = new Category();
                    categoryToAdd.Name = txtname.Text;
                    int res;
                    if (int.TryParse(txtDepId.Text, out res))
                    {
                        categoryToAdd.DepartmentID = res;

                        categoryManager.Add(categoryToAdd);
                    }
                    else
                    {
                        WebMessageBoxUtil.Show("Invalid input in Department field ");
                    }
                   
                }
            }
            catch (Exception exp) { }
            finally 
            {
                    CategoryDisplayGrid.EditIndex = -1;
                    BindGrid();
            }
        }

        protected void CategoryDisplayGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                CategoryBLL categoryManager = new CategoryBLL();
                Label ID = (Label)CategoryDisplayGrid.Rows[e.RowIndex].FindControl("lblCat_ID");
                int selectedId = int.Parse(ID.Text);
                Category categoryToDelete = new Category();//= empid.Text;
                categoryToDelete.CategoryID = selectedId;
                categoryManager.Delete(categoryToDelete);

            }
            catch (Exception exp) { }
            finally 
            {

                CategoryDisplayGrid.EditIndex = -1;
                BindGrid();
            }
        }

        protected void CategoryDisplayGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            CategoryDisplayGrid.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void CategoryDisplayGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                CategoryBLL categoryManager = new CategoryBLL();
                Label id = (Label)CategoryDisplayGrid.Rows[e.RowIndex].FindControl("lblCat_ID");
                TextBox name = (TextBox)CategoryDisplayGrid.Rows[e.RowIndex].FindControl("txtname");
                TextBox departmentId = (TextBox)CategoryDisplayGrid.Rows[e.RowIndex].FindControl("txtDepID");

                int selectedId = int.Parse(id.Text);
                Category categoryToUpdate = new Category();//= empid.Text;
                categoryToUpdate.CategoryID = selectedId;
                categoryToUpdate.Name = name.Text;
                int res;
                if (int.TryParse(departmentId.Text, out res))
                {
                    categoryToUpdate.DepartmentID = int.Parse(departmentId.Text);
                    categoryManager.Update(categoryToUpdate);
                }
                else
                {
                    WebMessageBoxUtil.Show("Invalid input in Department field ");
                }
               
            }
            catch (Exception exp) { }
            finally 
            {
                CategoryDisplayGrid.EditIndex = -1;
                BindGrid();
            }
        }

        private void BindGrid()
        {
            ds = CategoryBLL.GetAllCategories();
            CategoryDisplayGrid.DataSource = ds;
            CategoryDisplayGrid.DataBind();
        }
    }
}