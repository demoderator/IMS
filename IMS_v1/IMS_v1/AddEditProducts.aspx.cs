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
    public partial class AddEditProducts : System.Web.UI.Page
    {
        private DataSet ds;
        delegate void CloseMethodDelegate();

        protected void Page_Load(object sender, EventArgs e)
        {
            CloseMethodDelegate delInstance = new CloseMethodDelegate(CloseEvent);
            ucProdEdit.CloseParam = delInstance;
            if (!IsPostBack)
            {
                try
                {

                    BindGrid(false);
                    BindDrpProduct();
                   
                    
                }
                catch (Exception exp)
                {

                }
            }
        }

       
        protected void ProdDisplayGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ProdDisplayGrid.PageIndex = e.NewPageIndex;



            if (Session["SortedView"] != null)
            {
                ProdDisplayGrid.DataSource = Session["SortedView"];
                ProdDisplayGrid.DataBind();
            }
            else
            {
                ProdDisplayGrid.DataSource = ds;
                ProdDisplayGrid.DataBind();
            }

            BindGrid(false);
        }

        private void BindGrid(bool isDrpSelection)
        {
            ProductMaster obj = new ProductMaster();

            if (drpSerchProduct.SelectedValue != "" && isDrpSelection)
            {

                obj.ProductID = Convert.ToInt32(drpSerchProduct.SelectedValue);
                ds = ProductMasterBLL.GetProductMasterByID(obj);
                ProdDisplayGrid.DataSource = ds;
                ProdDisplayGrid.DataBind();
            }
            else
            {
                ds = ProductMasterBLL.GetAllProductMaster();
                ProdDisplayGrid.DataSource = ds;
                ProdDisplayGrid.DataBind();
            }

        }

        protected void ProdDisplayGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                ProductMasterBLL prodManager = new ProductMasterBLL();
                Label ID = (Label)ProdDisplayGrid.Rows[e.RowIndex].FindControl("lblProd_id");
                int selectedId = int.Parse(ID.Text);
                ProductMaster prodToDelete = new ProductMaster();//= empid.Text;
                prodToDelete.ProductID = selectedId;
                prodManager.Delete(prodToDelete);

            }
            catch (Exception exp) { }
            finally
            {
                ProdDisplayGrid.EditIndex = -1;
                BindGrid(false);
            }
        }
        protected void ProdDisplayGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if ((e.CommandName == "displayPopup")) 
            {
                Session["prod_ID"] = e.CommandArgument;
                Response.Redirect("GetExpiryDetails.aspx");
               
            }
            else if ((e.CommandName == "EditVal")) 
            {
                GridViewRow gvr = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);

                int RowIndex = gvr.RowIndex; 
                ProductMaster product = new ProductMaster();
                product.ProductID = int.Parse(((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_id")).Text);
                product.ProductName = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_Name")).Text;
                product.GreenRainCode = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_GRC")).Text;
                product.Manufacturer = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_Man")).Text;
                int res,res2,res4;
                if( int.TryParse((((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_pack")).Text),out res)){
                    product.Pack = res;
                }
                else
                {
                    product.Pack=10;
                }
                
                product.ProductCode = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_Code")).Text;
                product.ProductDescription = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_Desc")).Text;
                product.ProductSelection = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_sel")).Text;
                float res3;
                if (float.TryParse((((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_us")).Text), out res3))
                {
                    product.UnitSize = res3;
                }
                product.Upc = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_upc")).Text;
                product.WUnit = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_wunit")).Text;

                if (int.TryParse((((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_tsh")).Text), out res2))
                {
                    product.ThreshHold = res2;
                }
                product.ProductType = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_Type")).Text;

                if (int.TryParse((((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_subCatID")).Text), out res4))
                {
                    product.SubCategoryID = res4;
                }
                product.GenericName = ((Label)ProdDisplayGrid.Rows[RowIndex].FindControl("lblProd_Gen")).Text;
                ucProdEdit.CurrentSource = product;
                ucProdEdit.IsAdd = false;
                
                mpeEditProduct.Show();
               // LoadDataToEditPopup(int.Parse((string)e.CommandArgument));
            }
        }

       

        public SortDirection direction
        {
            get
            {
                if (ViewState["directionState"] == null)
                {
                    ViewState["directionState"] = SortDirection.Ascending;
                }
                return (SortDirection)ViewState["directionState"];
            }
            set
            {
                ViewState["directionState"] = value;
            }
        }

        
        protected void ProdDisplayGrid_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataView sortedView;
            string sortingDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                sortingDirection = "Desc";

            }
            else
            {
                direction = SortDirection.Ascending;
                sortingDirection = "Asc";

            }

            ds = ProductMasterBLL.GetAllProductMaster();
            ProdDisplayGrid.DataSource = ds;
            sortedView = new DataView(ds.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["SortedView"] = sortedView;
            ProdDisplayGrid.DataSource = sortedView;
            ProdDisplayGrid.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid(true);
        }


        public void BindDrpProduct()
        {

            ds = ProductMasterBLL.GetAllProductMaster();

            drpSerchProduct.DataSource = ds;
            drpSerchProduct.Items.Insert(0, new ListItem("Select Product", ""));
            drpSerchProduct.DataTextField = "ProductName";
            drpSerchProduct.DataValueField = "ProductID";

            drpSerchProduct.DataBind();

        }

        protected void CloseEvent()
        {
            try
            {
                
                mpeEditProduct.Hide();
                BindGrid(false);
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

        protected void BtnAddNew_Click(object sender, EventArgs e)
        {
            ucProdEdit.CurrentSource = new ProductMaster();
            ucProdEdit.IsAdd = true;
            mpeEditProduct.Show();
        }

           

   

        

        

       

    }
}