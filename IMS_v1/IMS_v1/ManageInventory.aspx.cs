using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class ManageInventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnManageOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageProducts.aspx");
        }

        protected void btnManageSubCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageSubCategory.aspx");
        }

        protected void btnManageCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageCategory.aspx");
        }

        protected void btnManageDepartment_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageDepartment.aspx");
        }

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WarehouseMain.aspx");
        }
    }
}