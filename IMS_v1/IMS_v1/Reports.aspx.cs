using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_DPS
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TreeView1.CollapseAll();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("HeadOfficeMain.aspx");
        }

        protected void btnBack_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HeadOfficeMain.aspx");
        }
    }
}