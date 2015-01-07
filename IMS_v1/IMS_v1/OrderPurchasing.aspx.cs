using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_DPS
{
    public partial class OrderPurchasing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAutoPurchaseOrder_Click(object sender, EventArgs e)
        {
           Response.Redirect("AutoPurchaseOrder.aspx");
        }

        protected void btnManualPurchaseOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManualPurchaseOrder.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WarehouseMain.aspx");
        }
    }
}