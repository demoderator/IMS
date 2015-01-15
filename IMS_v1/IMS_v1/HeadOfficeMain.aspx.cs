using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_DPS
{
    public partial class HeadOfficeMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStoreInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageInventory.aspx");
        }

        protected void btnVendors_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageVendors.aspx");
        }

        protected void btnReports_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

        protected void btnManageRoles_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageSystemRoles.aspx");
        }

        protected void btnManageStore_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageStores.aspx");
        }
    }
}