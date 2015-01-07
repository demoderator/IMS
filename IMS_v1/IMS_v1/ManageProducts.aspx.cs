using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddEditInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEditProducts.aspx");
        }

        protected void btnCheckInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckInventory_Products.aspx");
        }

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageInventory.aspx");
        }
    }
}