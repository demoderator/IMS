using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMSBusinessLogic;
using IMSCommon;

namespace IMS_v1
{
    public partial class VendorList : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindgdvVendor();
            }
        }


        public void BindgdvVendor()
        {
            ds = VendorBll.GetAllVendor();
            gdvVendor.DataSource = ds;
            gdvVendor.DataBind();


        }

        protected void gVStoreInfo_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gVStoreInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            gdvVendor.PageIndex = e.NewPageIndex;
          
            if (Session["SortedView"] != null)
            {
                gdvVendor.DataSource = Session["SortedView"];
                gdvVendor.DataBind();
            }
            else
            {
                gdvVendor.DataSource = ds;
                gdvVendor.DataBind();
            }  

            
        }

        protected void gVStoreInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gdvVendor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if ((e.CommandName == "del"))
            {
                Vendor obj = new Vendor();
                obj.supp_ID = e.CommandArgument.ToString();

                VendorBll objDel = new VendorBll();
                objDel.Delete(obj);

                BindgdvVendor();

            }
        }

        protected void gdvVendor_Sorting(object sender, GridViewSortEventArgs e)
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


            ds = VendorBll.GetAllVendor();
            gdvVendor.DataSource = ds;
            sortedView = new DataView(ds.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["SortedView"] = sortedView;
            gdvVendor.DataSource = sortedView;
            gdvVendor.DataBind();
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
    }
}