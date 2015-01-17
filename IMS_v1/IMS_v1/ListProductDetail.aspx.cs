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
    public partial class ListProductDetail : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProMasid"] != null)
                {
                    BindgdvlistProductDetail();

                }
            }
        }


        public void BindgdvlistProductDetail()
        {
            if (Request.QueryString["ProMasid"] != null)
            {
                ProductDetail obj = new ProductDetail();
                obj.ProductMasterID = Convert.ToInt32(Request.QueryString["ProMasid"]);
                ds = ProductDetailBLL.GetProductDetailByID(obj);
                gdvlistProductDetail.DataSource = ds;
                gdvlistProductDetail.DataBind();
            }
        }

        protected void gdvlistProductDetail_Sorting(object sender, GridViewSortEventArgs e)
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
            ProductDetail obj = new ProductDetail();
            obj.ProductMasterID = Convert.ToInt32(Request.QueryString["ProMasid"]);
            ds = ProductDetailBLL.GetProductDetailByID(obj);
            

            sortedView = new DataView(ds.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["SortedView"] = sortedView;
            gdvlistProductDetail.DataSource = sortedView;
            gdvlistProductDetail.DataBind();

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

        protected void gdvlistProductDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvlistProductDetail.PageIndex = e.NewPageIndex;

            if (Session["SortedView"] != null)
            {
                gdvlistProductDetail.DataSource = Session["SortedView"];
                gdvlistProductDetail.DataBind();
            }
            else
            {
                gdvlistProductDetail.DataSource = ds;
                gdvlistProductDetail.DataBind();
            }  
        }
    }
}