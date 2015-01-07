using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class WarehouseMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnManageOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageOrders.aspx");
        }

        protected void btnManageInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageInventory.aspx");
        }

        protected void btnManageStores_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageStores.aspx");
        }

        protected void btnManageVendors_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageVendors.aspx");
        }
    }
}