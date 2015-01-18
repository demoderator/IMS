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
    public partial class AddEditProducts : System.Web.UI.Page
    {
        private DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                    BindGrid();
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

            BindGrid();
        }

        private void BindGrid()
        {
            ProductMaster obj = new ProductMaster();

            if (drpSerchProduct.SelectedValue != "")
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

        protected void ProdDisplayGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if ((e.CommandName == "del"))
            {
                ProductMaster obj = new ProductMaster();
                obj.ProductID = Convert.ToInt16(e.CommandArgument);

                ProductMasterBLL objDel = new ProductMasterBLL();
                objDel.Delete(obj);

                BindGrid();

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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BindGrid();
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

    }
}