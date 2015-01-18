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
    public partial class CheckInventory_Products : System.Web.UI.Page
    {
        private DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                try
                {
                    // drpSerchUser.Items.Insert(0, new ListItem("Select Product", ""));

                    BindGrid();
                    BindDrpSearch();
                }
                catch (Exception exp) { }
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
        public void BindDrpSearch()
        {
            ds = ProductMasterBLL.GetAllProductMaster();
            drpSerchUser.DataSource = ds;
            drpSerchUser.Items.Insert(0, new ListItem("Select Product", ""));
            drpSerchUser.DataTextField = "ProductName";
            drpSerchUser.DataValueField = "ProductID";

            drpSerchUser.DataBind();
        }
        private void BindGrid()
        {


            if (drpSerchUser.SelectedValue!="")
            {
                StockDetails objdrp = new StockDetails();
                objdrp.ProductID = Convert.ToInt32(drpSerchUser.SelectedValue);
                objdrp.UserRoleID = Convert.ToInt32(Session["UserID"]);
                ds = stockDetailsBll.GetStockDetailSearch(objdrp);
                ProdDisplayGrid.DataSource = ds;
                ProdDisplayGrid.DataBind();

            }
            else
            {

                StockDetails obj1 = new StockDetails();
                obj1.UserRoleID = Convert.ToInt32(Session["UserID"]);
                ds = stockDetailsBll.GetStockDetailSearch(obj1);
                ProdDisplayGrid.DataSource = ds;
                ProdDisplayGrid.DataBind();
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

            if (drpSerchUser.SelectedIndex != -1)
            {
                StockDetails objsort = new StockDetails();

                objsort.ProductID = Convert.ToInt32(drpSerchUser.SelectedValue);
                ds = stockDetailsBll.GetStockDetailSearch(objsort);
                ProdDisplayGrid.DataSource = ds;
                ProdDisplayGrid.DataBind();
            }

            else
            {

                StockDetails objGrid = new StockDetails();
                objGrid.UserRoleID = Convert.ToInt32(Session["UserID"]);
                ds = stockDetailsBll.GetStockDetailSearch(objGrid);
            }


            ProdDisplayGrid.DataSource = ds;
            sortedView = new DataView(ds.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["SortedView"] = sortedView;
            ProdDisplayGrid.DataSource = sortedView;
            ProdDisplayGrid.DataBind();
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BindGrid();
        }


    }
}