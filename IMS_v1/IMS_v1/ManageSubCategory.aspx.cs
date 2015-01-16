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
    public partial class ManageSubCategory : System.Web.UI.Page
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

        protected void SubCategoryDisplayGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            SubCategoryDisplayGrid.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void SubCategoryDisplayGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            SubCategoryDisplayGrid.EditIndex = -1;
            BindGrid();
        }

        protected void SubCategoryDisplayGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Add"))
                {
                    SubCategoryBLL subCategoryManager = new SubCategoryBLL();
                    TextBox txtname = (TextBox)SubCategoryDisplayGrid.FooterRow.FindControl("txtAddname");
                    TextBox txtCatId = (TextBox)SubCategoryDisplayGrid.FooterRow.FindControl("txtAddCatID");

                    SubCategory subCategoryToAdd = new SubCategory();
                    subCategoryToAdd.Name = txtname.Text;
                    int res;
                    if (int.TryParse(txtCatId.Text, out res))
                    {
                        subCategoryToAdd.CategoryID = res;
                        subCategoryManager.Add(subCategoryToAdd);
                    }
                    else
                    {
                        WebMessageBoxUtil.Show("Invalid input in Category field ");
                    }
                 }
                else if (e.CommandName.Equals("UpdateSubCategory")) 
                {
                    SubCategoryBLL subCategoryManager = new SubCategoryBLL();
                    Label id = (Label)SubCategoryDisplayGrid.Rows[SubCategoryDisplayGrid.EditIndex].FindControl("lblSubCat_ID");
                    TextBox name = (TextBox)SubCategoryDisplayGrid.Rows[SubCategoryDisplayGrid.EditIndex].FindControl("txtname");
                    DropDownList ddlDep = (DropDownList)(SubCategoryDisplayGrid.Rows[SubCategoryDisplayGrid.EditIndex].FindControl("ddlCategoryName"));
                    string catName = ddlDep.SelectedItem.Value;
                    

                    int selectedId = int.Parse(id.Text);
                    SubCategory subCategoryToUpdate = new SubCategory();//= empid.Text;
                    subCategoryToUpdate.SubCategoryID = selectedId;
                    subCategoryToUpdate.Name = name.Text;
                    int res;
                    if (int.TryParse(catName, out res))
                    {
                        subCategoryToUpdate.CategoryID = res;
                        subCategoryManager.Update(subCategoryToUpdate);
                    }
                    else
                    {
                        WebMessageBoxUtil.Show("Invalid input in Category field ");
                    }
                }
            }
            catch (Exception exp) { }
            finally 
            {
                SubCategoryDisplayGrid.EditIndex = -1;
                BindGrid();
            }
        }

        protected void SubCategoryDisplayGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                SubCategoryBLL subCategoryManager = new SubCategoryBLL();
                Label ID = (Label)SubCategoryDisplayGrid.Rows[e.RowIndex].FindControl("lblSubCat_ID");
                int selectedId = int.Parse(ID.Text);
                SubCategory subCategoryToDelete = new SubCategory();//= empid.Text;
                subCategoryToDelete.SubCategoryID = selectedId;
                subCategoryManager.Delete(subCategoryToDelete);

               
            }
            catch (Exception exp) { }
            finally 
            {
                SubCategoryDisplayGrid.EditIndex = -1;
                BindGrid();
            }
        }

        protected void SubCategoryDisplayGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            SubCategoryDisplayGrid.EditIndex = e.NewEditIndex;
            BindGrid();
        }

     
        private void BindGrid()
        {
            ds = SubCategoryBLL.GetAllSubCategories();
            SubCategoryDisplayGrid.DataSource = ds;
            SubCategoryDisplayGrid.DataBind();

            DropDownList catList = (DropDownList)SubCategoryDisplayGrid.FooterRow.FindControl("ddlAddCategoryName");
            catList.DataSource = CategoryBLL.GetAllCategories();
            catList.DataBind();
            catList.DataTextField = "categoryName";
            catList.DataValueField = "categoryID";
            catList.DataBind();
        }

        protected void SubCategoryDisplayGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && SubCategoryDisplayGrid.EditIndex == e.Row.RowIndex)
            {
                try
                {
                    DropDownList catList = (DropDownList)e.Row.FindControl("ddlCategoryName");
                    catList.DataSource = CategoryBLL.GetAllCategories();
                    catList.DataBind();
                    catList.DataTextField = "categoryName";
                    catList.DataValueField = "categoryID";
                    catList.DataBind();
                   
                }
                catch (Exception exo)
                { }
            }
        }
    }
}