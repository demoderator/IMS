using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMSCommon;
using IMSBusinessLogic;
using System.Data;
using IMSCommon.Util;

namespace IMS_v1
{
    public partial class SendToStore : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindOrderType();
                plhMaster.Visible = true;

                plsChilde.Visible = false;
                BindDrpORderTo();
                BindDrpProduct();

            }
        }



        public void BindOrderType()
        {
            List<ListItem> items = new List<ListItem>();
            items.Add(new ListItem("Select Type", "0"));
            if (Session["Type"] == "WareHouse")
            {


                items.Add(new ListItem("Store", "2"));

                //  items.Add(new ListItem("Vendor", "5"));
            }

      
                

            

            drpOrderType.Items.AddRange(items.ToArray());



        }
        public void AddNewOrder()
        {

            OrderDetails obj = new OrderDetails();
            obj.OrderDate = DateTime.Now;
            obj.OrderAmount = float.Parse("00");
            obj.UserID = Convert.ToInt32(Session["UserID"]);
            obj.OrderStatus = "Pending";
            obj.OrderRequestBy = Convert.ToInt32(Session["UserID"]);
            obj.OrderRequestedFor = Convert.ToInt32(drpOrderTo.SelectedValue);
            obj.OrderTypeID = Convert.ToInt32(drpOrderType.SelectedValue);
            obj.OrderMode = "Request";
            ds = PlaceOrderBLL.GetNewOrderDetails(obj);

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            plhMaster.Visible = false;

            plsChilde.Visible = true;
            AddNewOrder();
            AddOrderDetails();
            BindGdvDetails();
        }


        public void BindDrpORderTo()
        {

            if (drpOrderType.SelectedValue != null && drpOrderType.SelectedValue != "5")
            {

                string abc = drpOrderType.SelectedValue;
                DataSet getUser = new DataSet();
                UserRoles ur = new UserRoles();
                ur.UserRoleId = Convert.ToInt32(drpOrderType.SelectedValue);
                getUser = UserRoleBLL.GetUserRoleById(ur);
                drpOrderTo.DataSource = getUser;
                drpOrderTo.DataTextField = "userRoleName";
                drpOrderTo.DataValueField = "userRoleID";
                drpOrderTo.DataBind();
            }


            //GetUserRoleById
        }

        protected void drpOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDrpORderTo();
        }




        public void BindDrpProduct()
        {
            DataSet dspro = new DataSet();
            dspro = ProductBLL.GetAvailableProducts();


            drpSerchProduct.DataSource = dspro;

            drpSerchProduct.DataTextField = "ProductName";
            drpSerchProduct.DataValueField = "ProductID";

            drpSerchProduct.DataBind();

        }



        public void AddOrderDetails()
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                OrderDetails objDetails = new OrderDetails();

                objDetails.OrderID = Convert.ToInt32(ds.Tables[0].Rows[0]["OrderID"]);
                objDetails.ProductID = Convert.ToInt32(drpSerchProduct.SelectedValue);
                objDetails.OrderDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["OrderDate"]);
                objDetails.OrderedQuantity = Convert.ToInt32(txtQuantity.Text);
                objDetails.StatusDetails = "Initiated";
                objDetails.SalePrice =Convert.ToInt32( txtPrize.Text);
                objDetails.OrderDescription = "Requested";
                PlaceOrderBLL objAdd = new PlaceOrderBLL();
                objAdd.AddOrderDetails(objDetails);
            }
        }


        public void BindGdvDetails()
        {
            DataSet ds2 = new DataSet();
            OrderDetails objDetails = new OrderDetails();

            if (Session["OrderID"] == null)
            {

                Session["OrderID"] = Convert.ToInt32(ds.Tables[0].Rows[0]["OrderID"]);
            }
            objDetails.OrderID = Convert.ToInt32(Session["OrderID"]);

            ds2 = PlaceOrderBLL.GetOrderDetailsById(objDetails);

            gdvOrderDetail.DataSource = ds2;
            gdvOrderDetail.DataBind();

            if (plsChilde.Visible == true)
            {
                if (Session["OrderID"] != null)
                {
                    DataSet dspro = new DataSet();
                   dspro= ProductBLL.GetAvailableProducts();

                    DropDownList drpOrderDetail = (DropDownList)gdvOrderDetail.FooterRow.FindControl("drpAddOrderDetail");


                    drpOrderDetail.DataSource = dspro;

                    drpOrderDetail.DataTextField = "ProductName";
                    drpOrderDetail.DataValueField = "ProductID";

                    drpOrderDetail.DataBind();
                }
            }


        }

        protected void gdvOrderDetail_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvOrderDetail.EditIndex = e.NewEditIndex;
            BindGdvDetails();
        }

        protected void gdvOrderDetail_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvOrderDetail.EditIndex = -1;
            BindGdvDetails();
        }

        protected void gdvOrderDetail_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Add"))
                {
                    OrderDetails objDetails = new OrderDetails();

                    TextBox txtAddquantity = (TextBox)gdvOrderDetail.FooterRow.FindControl("txtAddquantity");

                    TextBox txtAddSalePrice = (TextBox)gdvOrderDetail.FooterRow.FindControl("txtAddSalePrice");
                    DropDownList drpOrderDetail = (DropDownList)gdvOrderDetail.FooterRow.FindControl("drpAddOrderDetail");
                    objDetails.OrderID = Convert.ToInt32(Session["OrderID"]);
                    objDetails.ProductID = Convert.ToInt32(drpOrderDetail.SelectedValue);
                    objDetails.OrderDate = DateTime.Now;
                    objDetails.StatusDetails = "Initiated";
                    objDetails.OrderDescription = "Requested";
                    objDetails.OrderedQuantity = Convert.ToInt32(txtAddquantity.Text);
                    objDetails.SalePrice = Convert.ToInt32(txtAddSalePrice.Text);

                    PlaceOrderBLL objAdd = new PlaceOrderBLL();
                    objAdd.AddOrderDetails(objDetails);
                }
                else if (e.CommandName.Equals("Del"))
                {
                    PlaceOrderBLL objDel = new PlaceOrderBLL();

                    OrderDetails objOrer = new OrderDetails();
                    objOrer.OrderDetailID = Convert.ToInt32(e.CommandArgument);

                    objDel.Delete(objOrer);

                }

                else if (e.CommandName.Equals("Upd"))
                {
                    PlaceOrderBLL objupd = new PlaceOrderBLL();

                    OrderDetails objOrder = new OrderDetails();

                    TextBox txtSalePrice = (TextBox)gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("txtSalePrice");
                    TextBox txtquantity = (TextBox)gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("txtquantity");
                    DropDownList ddlPro = (DropDownList)(gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("drpOrderDetail"));
                    long DrpPro = Convert.ToInt64(ddlPro.SelectedItem.Value);
                    objOrder.OrderDetailID = Convert.ToInt32(e.CommandArgument);
                    objOrder.SalePrice = Convert.ToInt32(txtSalePrice.Text);
                    objOrder.ProductID = DrpPro;
                    objOrder.OrderDescription = "Requested";
                    objOrder.OrderedQuantity = Convert.ToInt32(txtquantity.Text);
                    objupd.update(objOrder);

                }
                else
                {
                    //WebMessageBoxUtil.Show("Invalid input in Order Place field ");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {


                gdvOrderDetail.EditIndex = -1;
                BindGdvDetails();
            }
        }

        protected void gdvOrderDetail_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    try
                    {
                        DataSet dspro = new DataSet();
                        dspro = ProductBLL.GetAvailableProducts();
                        DropDownList depList = (DropDownList)e.Row.FindControl("drpOrderDetail");
                        depList.DataSource = dspro;

                        depList.DataTextField = "ProductName";
                        depList.DataValueField = "ProductID";
                        depList.DataBind();
                        depList.Items.FindByValue((e.Row.FindControl("lblProductName_Id") as Label).Text).Selected = true;

                        DataRowView dr = e.Row.DataItem as DataRowView;
                        depList.SelectedValue = (string)e.Row.DataItem; // you can use e.Row.DataItem to get the value
                    }
                    catch (Exception exo)
                    { }
                }
            }
        }

        protected void btnFinal_Click(object sender, EventArgs e)
        {
            Session["OrderID"] = null;


            if (Session["Type"] == "WareHouse")
            {


                // items.Add(new ListItem("WareHouse", "1"));
                Response.Redirect("WarehouseMain.aspx");

            }

            else if (Session["Type"] == "Store")
            {
                Response.Redirect("StoreMain.aspx");
            }
        }
    }
}