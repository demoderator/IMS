using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgbtn3_Click(object sender, ImageClickEventArgs e)
        {
            txtUse.Text = "headoffice";
            txtUse.Enabled = false;
            HtmlGenericControl Div = (HtmlGenericControl)FindControl("choice3");
            Div.Attributes["class"] = "col-lg-4 options-se selected";
            imgbtn3.ImageUrl = "images/hq-on.png";

            HtmlGenericControl Div1 = (HtmlGenericControl)FindControl("choice2");
            Div1.Attributes["class"] = "col-lg-4 options-se";
            imgbtn2.ImageUrl = "images/store-in.png";

            HtmlGenericControl Div2 = (HtmlGenericControl)FindControl("choice1");
            Div2.Attributes["class"] = "col-lg-4 options-se";
            imgbtn1.ImageUrl = "images/warehouse-in.png";
        }

        protected void imgbtn2_Click(object sender, ImageClickEventArgs e)
        {
            txtUse.Text = "store";
            txtUse.Enabled = false;
            Session["UserID"] = 2;
            HtmlGenericControl Div = (HtmlGenericControl)FindControl("choice2");
            Div.Attributes["class"] = "col-lg-4 options-se selected";
            imgbtn2.ImageUrl = "images/store-on.png";

            HtmlGenericControl Div1 = (HtmlGenericControl)FindControl("choice3");
            Div1.Attributes["class"] = "col-lg-4 options-se";
            imgbtn3.ImageUrl = "images/hq-in.png";

            HtmlGenericControl Div2 = (HtmlGenericControl)FindControl("choice1");
            Div2.Attributes["class"] = "col-lg-4 options-se";
            imgbtn1.ImageUrl = "images/warehouse-in.png";
        }

        protected void imgbtn1_Click(object sender, ImageClickEventArgs e)
        {
            txtUse.Text = "warehouse";
            Session["UserID"] = 1;
            txtUse.Enabled = false;
            HtmlGenericControl Div = (HtmlGenericControl)FindControl("choice1");
            Div.Attributes["class"] = "col-lg-4 options-se selected";
            imgbtn1.ImageUrl = "images/warehouse-on.png";

            HtmlGenericControl Div1 = (HtmlGenericControl)FindControl("choice2");
            Div1.Attributes["class"] = "col-lg-4 options-se";
            imgbtn2.ImageUrl = "images/store-in.png";

            HtmlGenericControl Div2 = (HtmlGenericControl)FindControl("choice3");
            Div2.Attributes["class"] = "col-lg-4 options-se";
            imgbtn3.ImageUrl = "images/hq-in.png";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String UserName = txtUse.Text;
            String UserPass = txtPas.Text;

            UserName = UserName.ToLower();
            UserPass = UserPass.ToLower();

            Session["User"] = UserName;
            Session["Pass"] = UserPass;

            if (UserName.Equals("warehouse") && UserPass.Equals("warehouse"))
            {
                Session["Type"] = "WareHouse";
                Session["UserID"] = 1;
                Response.Redirect("WarehouseMain.aspx");
            }
            else if (UserName.Equals("headoffice") && UserPass.Equals("headoffice"))
            {
               
                Response.Redirect("HeadOfficeMain.aspx");
            }
            else if (UserName.Contains("store") && UserPass.Contains("store"))
            {
                Session["Type"] = "Store";
                Session["UserID"] = 2;
                Response.Redirect("StoreMain.aspx");
            }
        }
    }
}