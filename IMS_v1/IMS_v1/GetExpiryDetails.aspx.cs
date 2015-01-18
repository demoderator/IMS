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
    public partial class GetExpiryDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindgdvDetails();
            }
        }

        protected void gdvDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gdvDetails_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        public void BindgdvDetails()
        {
            DataSet ds = new DataSet();

            StockDetails objdrp = new StockDetails();
            objdrp.ProductID = Convert.ToInt32(Request.QueryString["Pid"]);
            objdrp.UserRoleID = Convert.ToInt32(Request.QueryString["uId"]);
            ds = stockDetailsBll.GetStockDetailSearchExpiry(objdrp);
            gdvDetails.DataSource = ds;
            gdvDetails.DataBind();
        }
    }
}