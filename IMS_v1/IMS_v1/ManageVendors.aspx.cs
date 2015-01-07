using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class ManageVendors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditVendor.aspx");
        }

        protected void btnVendor_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewVendor.aspx");
        }

        protected void btnback_Click(object sender, EventArgs e)
        {

        }
    }
}