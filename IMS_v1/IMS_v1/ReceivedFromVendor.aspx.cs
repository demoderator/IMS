using IMSBusinessLogic;
using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace IMS_v1
{
    public partial class ReceivedFromVendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGdvReceived();


            }
        }
        public void BindGdvReceived()
        {

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                DataSet ds2 = new DataSet();
                OrderDetails objDetails = new OrderDetails();

                objDetails.OrderRequestedFor = Convert.ToInt32(Session["UserID"]);

                objDetails.OrderRequestBy = Convert.ToInt32(Session["UserID"]);
                objDetails.OrderID = Convert.ToInt32(txtSearch.Text);
                objDetails.OrderMode = "vendore";
                ds2 = PlaceOrderBLL.GetPenddingOrders(objDetails);

                gdvReceived.DataSource = ds2;
                gdvReceived.DataBind();
            }
        }
        protected void gdvReceived_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            gdvReceived.PageIndex = e.NewPageIndex;
            BindGdvReceived();
        }



        public string ReturnDetailsStatus(string status)
        {

            if (status == "Cancel")
            {


                return " <a href='#' style='visibility:hidden'>Recived</a>";
            }

            else
            {
                return " <a href='#'>Recived</a>";

            }

        }

        protected void gdvReceived_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvReceived.EditIndex = e.NewEditIndex;
            BindGdvReceived();
        }

        protected void gdvReceived_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvReceived.EditIndex = -1;
            BindGdvReceived();
        }

        protected void gdvReceived_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {


                if (e.CommandName.Equals("Upd"))
                {
                    PlaceOrderBLL objupd = new PlaceOrderBLL();

                    OrderDetails objOrder = new OrderDetails();
                    TextBox detailDescription = (TextBox)gdvReceived.Rows[gdvReceived.EditIndex].FindControl("txtDetailDescription");

                    TextBox recivedQunatity = (TextBox)gdvReceived.Rows[gdvReceived.EditIndex].FindControl("txtOrderedQuantity");
                    TextBox SalePrice = (TextBox)gdvReceived.Rows[gdvReceived.EditIndex].FindControl("txtSalePrice");

                    TextBox txtDateExpired = (TextBox)gdvReceived.Rows[gdvReceived.EditIndex].FindControl("txtDateExpired");
                    objOrder.ExpiryDate = Convert.ToDateTime(txtDateExpired.Text);
                  
                    objOrder.OrderDetailID = Convert.ToInt32(e.CommandArgument);
                    objOrder.ReceivedQuantity = Convert.ToInt32(recivedQunatity.Text);
                    objOrder.RoleType = Session["Type"].ToString();
                    objOrder.OrderDescription = detailDescription.Text;
                  
                    objOrder.SalePrice = Convert.ToInt32(SalePrice.Text);
                    objOrder.ReceivedDate = DateTime.Now;

                    objupd.updateOrderByStatus(objOrder);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                gdvReceived.EditIndex = -1;
                BindGdvReceived();
            }
        }

        protected void gdvReceived_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblStatus = (Label)e.Row.FindControl("lblstatus");
                LinkButton lnbtn = (LinkButton)e.Row.FindControl("btnEdit");

                if (lblStatus.Text == "Initiated")
                {

                    if (lnbtn != null)
                    {

                        lnbtn.Visible = true;
                    }

                }

                else
                {
                    if (lnbtn != null)
                    {
                        lnbtn.Visible = false;
                    }

                }
            }



        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindGdvReceived();

        }

    }
}