using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class StoreMain : System.Web.UI.Page
    {
        string userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            userid = Session["UserID"].ToString();

        }

        protected void btnStoreInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageInventory.aspx");
        }

        protected void btnPicking_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecivedOrder.aspx");
        }

        protected void btnVendors_Click(object sender, EventArgs e)
        {

        }

        protected void btnManageOrders_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnPlaceOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManualPurchaseOrder.aspx");
            
        }
    }
}