using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class ManageOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WarehouseMain.aspx");
        }

        protected void btnPlaceOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderPurchasing.aspx");
        }

        protected void btnPendingOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("PendingOrders.aspx");
        }

        protected void btnHisotryOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("HistoryOrders.aspx");
        }

        protected void btnRecieveOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecieveOrder.aspx");
        }
    }
}