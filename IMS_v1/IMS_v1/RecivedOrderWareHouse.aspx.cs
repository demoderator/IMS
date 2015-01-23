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
    public partial class RecivedOrderWareHouse : System.Web.UI.Page
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
                objDetails.OrderMode = "wareHouse";
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

                    TextBox SalePrice = (TextBox)gdvReceived.Rows[gdvReceived.EditIndex].FindControl("txtSalePrice");
                    Label lblExpiry = (Label)gdvReceived.Rows[gdvReceived.EditIndex].FindControl("lblExpiry");

                    Label lblProductDetail = (Label)gdvReceived.Rows[gdvReceived.EditIndex].FindControl("lblProductDetail");
                    objOrder.OrderDetailID = Convert.ToInt32(e.CommandArgument);
                    objOrder.ReceivedDate = DateTime.Now;
                    objOrder.OrderDescription = detailDescription.Text;
                    objOrder.ExpiryDate = DateTime.Now;
                    objOrder.SalePrice = Convert.ToInt32(SalePrice.Text);
                    objOrder.RoleType = Session["Type"].ToString();
                    objOrder.ExpiryDate = Convert.ToDateTime(lblExpiry.Text);

                    objOrder.StatusDetails = "Complete";

                    objOrder.ProductDetailId = Convert.ToInt32(lblProductDetail.Text);

                    objupd.updateOrderByStatus(objOrder);
                }

                else if (e.CommandName.Equals("discard"))
                {
                    PlaceOrderBLL objupd = new PlaceOrderBLL();

                    OrderDetails objOrder = new OrderDetails();


                    objOrder.OrderDetailID = Convert.ToInt32(e.CommandArgument);
                    objOrder.ReceivedDate = DateTime.Now;
                    objOrder.ExpiryDate = DateTime.Now;
                    objOrder.RoleType = Session["Type"].ToString();
                    objOrder.OrderDescription = "Stock Not Available";
                    objOrder.StatusDetails = "Cancel";
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
                LinkButton lbldiscard = (LinkButton)e.Row.FindControl("lbldiscard");
                Label lblAvailable = (Label)e.Row.FindControl("lblAvailable");
                Label lblOrderQuantity = (Label)e.Row.FindControl("lblOrderQuantity");


                if (lblAvailable.Text == "0")
                {



                    lnbtn.Visible = false;


                    lbldiscard.Visible = false;


                }



                if (lblStatus.Text == "Pending" && lblAvailable.Text != "0" && Convert.ToInt32(lblAvailable.Text) >= Convert.ToInt32(lblOrderQuantity.Text))
                {

                    if (lnbtn != null)
                    {

                        lnbtn.Visible = true;
                    }
                    if (lbldiscard != null)
                    {
                        lbldiscard.Visible = true;
                    }
                }

                else
                {
                    if (lblAvailable.Text == "0")
                    {
                        lblAvailable.ForeColor = System.Drawing.Color.Red;
                        lblAvailable.Text = "Stock not available Please update";
                    }
                    else if (Convert.ToInt32(lblAvailable.Text) <= Convert.ToInt32(lblOrderQuantity.Text))
                    {
                        lblAvailable.ForeColor = System.Drawing.Color.Red;
                        lblAvailable.Text = lblAvailable.Text + " (Low quantity)";
                    }

                    else
                    {
                        lblAvailable.ForeColor = System.Drawing.Color.Black;
                        lblAvailable.Text = lblAvailable.Text;
                    }
                    lbldiscard.Visible = false;
                    lnbtn.Visible = false;
                }
            }



        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindGdvReceived();
        }
    }

}