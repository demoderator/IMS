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


                    SubCategoryDisplayGrid.EditIndex = -1;
                    BindGrid();
                }
            }
            catch (Exception exp) { }
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

                SubCategoryDisplayGrid.EditIndex = -1;
                BindGrid();
            }
            catch (Exception exp) { }
        }

        protected void SubCategoryDisplayGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            SubCategoryDisplayGrid.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void SubCategoryDisplayGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                SubCategoryBLL subCategoryManager = new SubCategoryBLL();
                Label id = (Label)SubCategoryDisplayGrid.Rows[e.RowIndex].FindControl("lblSubCat_ID");
                TextBox name = (TextBox)SubCategoryDisplayGrid.Rows[e.RowIndex].FindControl("txtname");
                TextBox catId = (TextBox)SubCategoryDisplayGrid.Rows[e.RowIndex].FindControl("txtCatID");

                int selectedId = int.Parse(id.Text);
                SubCategory subCategoryToUpdate = new SubCategory();//= empid.Text;
                subCategoryToUpdate.SubCategoryID = selectedId;
                subCategoryToUpdate.Name = name.Text;
                int res;
                if (int.TryParse(catId.Text, out res))
                {
                    subCategoryToUpdate.CategoryID = res;
                    subCategoryManager.Update(subCategoryToUpdate);
                }
                else
                {
                    WebMessageBoxUtil.Show("Invalid input in Category field ");
                }


                SubCategoryDisplayGrid.EditIndex = -1;
                BindGrid();
            }
            catch (Exception exp) { }
        }

        private void BindGrid()
        {
            ds = SubCategoryBLL.GetAllSubCategories();
            SubCategoryDisplayGrid.DataSource = ds;
            SubCategoryDisplayGrid.DataBind();
        }
    }
}