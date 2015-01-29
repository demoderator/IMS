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

    public partial class ManualPurchaseOrder : System.Web.UI.Page
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


                // items.Add(new ListItem("WareHouse", "1"));

                items.Add(new ListItem("Vendor", "5"));
            }

            else if (Session["Type"] == "Store")
            {
                //  items.Add(new ListItem("Store", "2"));

                items.Add(new ListItem("WareHouse", "1"));

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
            if (drpOrderType.SelectedValue == "5")
            {
                obj.OrderRequestedFor = Convert.ToInt32(Session["UserID"]);
                obj.VendorID = drpOrderTo.SelectedValue;
                obj.OrderMode = "vendor";
            }
            else
            {

                obj.OrderRequestedFor = Convert.ToInt32(drpOrderTo.SelectedValue);
                obj.OrderMode = "Demand";
            }
            obj.OrderTypeID = Convert.ToInt32(drpOrderType.SelectedValue);

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

            if (drpOrderType.SelectedValue == "5")
            {
                DataSet dsVendor = VendorBll.GetAllVendor();
                drpOrderTo.DataSource = dsVendor;
                drpOrderTo.DataSource = dsVendor;

                drpOrderTo.DataTextField = "SupName";
                drpOrderTo.DataValueField = "Supp_ID";

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
            dspro = ProductMasterBLL.GetAllProductMaster();


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

                if (Session["Type"] == "WareHouse")
                {
                    objDetails.StatusDetails = "Initiated";
                }

                else if (Session["Type"] == "Store")
                {
                    objDetails.StatusDetails = "Pending";
                }

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


            if (Session["OrderID"] != null)
            {
                DataSet dspro = new DataSet();
                dspro = ProductMasterBLL.GetAllProductMaster();

                DropDownList drpOrderDetail = (DropDownList)gdvOrderDetail.FooterRow.FindControl("drpAddOrderDetail");


                drpOrderDetail.DataSource = dspro;

                drpOrderDetail.DataTextField = "ProductName";
                drpOrderDetail.DataValueField = "ProductID";

                drpOrderDetail.DataBind();
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

                    DropDownList drpOrderDetail = (DropDownList)gdvOrderDetail.FooterRow.FindControl("drpAddOrderDetail");
                    objDetails.OrderID = Convert.ToInt32(Session["OrderID"]);
                    objDetails.ProductID = Convert.ToInt32(drpOrderDetail.SelectedValue);
                   // objDetails.SalePrice = float.Parse(((Label)gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("lblSP")).Text);
                    //objDetails.CostPrice = float.Parse(((Label)gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("lblCP")).Text);
                    objDetails.OrderDate = DateTime.Now;
                    if (Session["Type"] == "WareHouse")
                    {
                        objDetails.StatusDetails = "Initiated";
                    }

                    else if (Session["Type"] == "Store")
                    {
                        objDetails.StatusDetails = "Pending";
                    }

                    objDetails.OrderedQuantity = Convert.ToInt32(txtAddquantity.Text);

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



                    TextBox txtquantity = (TextBox)gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("txtquantity");
                    DropDownList ddlPro = (DropDownList)(gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("drpOrderDetail"));
                    long DrpPro = Convert.ToInt64(ddlPro.SelectedItem.Value);
                    objOrder.OrderDetailID = Convert.ToInt32(e.CommandArgument);
                    objOrder.ProductID = DrpPro;
                    objOrder.SalePrice = float.Parse(((Label)gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("lblSP")).Text);
                    objOrder.CostPrice = float.Parse(((Label)gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("lblCP")).Text);
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
                        dspro = ProductMasterBLL.GetAllProductMaster();
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

        protected void drpOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList dpList = (DropDownList)sender;
            ProductDetail pd = new ProductDetail();
            pd.ProductMasterID = int.Parse(dpList.SelectedValue);
            DataSet ds_temp = ProductDetailBLL.GetProductDetailByID(pd);
            
          
           // ds_temp.Tables[0].Columns
                //Label lbl = gdvOrderDetail.Rows[gdvOrderDetail.SelectedIndex].FindControl("lblCP") as Label;
            //lbl.Text = "1.0";

            //Label lbl_SP = gdvOrderDetail.Rows[gdvOrderDetail.SelectedIndex].FindControl("lblSP") as Label;
            //lbl_SP.Text = "1.2";

            Label lbl = gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("lblSP") as Label;
            lbl.Text = "3.2";

            Label lbl1 = gdvOrderDetail.Rows[gdvOrderDetail.EditIndex].FindControl("lblCP") as Label;
            lbl1.Text = "2.2"; 
        }

        //protected void drpAddOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //DropDownList dpList = (DropDownList)sender;
        //    //ProductDetail pd = new ProductDetail();
        //    //pd.ProductMasterID = int.Parse(dpList.SelectedValue);
        //    //DataSet ds_temp = ProductDetailBLL.GetProductDetailByID(pd);
            
        //    //Label lbl = gdvOrderDetail.Rows[gdvOrderDetail.SelectedIndex].FindControl("lblSP") as Label;
        //    //lbl.Text = "3.2";

        //    //Label lbl1 = gdvOrderDetail.Rows[gdvOrderDetail.SelectedIndex].FindControl("lblCP") as Label;
        //    //lbl1.Text = "2.2"; 
        //}

       

    }
}