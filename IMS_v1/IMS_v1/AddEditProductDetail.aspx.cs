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
    public partial class AddEditProductDetail : System.Web.UI.Page
    {


        public DateTime DateCreated, DateUpdated, DateExpired;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BinddrpCatogory();

                if (Request.QueryString["detaiiId"] != null)
                {
                    loadData();
                }
            }
        }
        public void BinddrpCatogory()
        {
            try
            {

                DataSet ds2 = new DataSet();
                ds2 = ProductMasterBLL.GetAllProductMaster();
                drpProductMaster.Items.Insert(0, new ListItem("Select Product", ""));
                drpProductMaster.DataSource = ds2;
                drpProductMaster.DataValueField = "ProductID";
                drpProductMaster.DataTextField = "ProductName";
                drpProductMaster.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["detaiiId"] != null)
            {
                UpdateProductDetail();
            }
            else
            {
                AddProductDetail();
            }
        }


        public void AddProductDetail()
        {
            try
            {
                ProductDetail obj = new ProductDetail();
                obj.ProductMasterID = Convert.ToInt32(drpProductMaster.SelectedValue);
                obj.Quantity = float.Parse(txtQuantityUnit.Text);
                obj.CostPrice = float.Parse(txtCostPrice.Text);
                obj.SalePrice = float.Parse(txtSalePrice.Text);
                obj.Discount = (txtDiscount.Text);
                obj.Status = txtStatus.Text;
                obj.DateCreated = DateTime.Now;
                obj.DateUpdated = DateTime.Now;
                obj.DateExpired = DateTime.Now.AddDays(1000);

                ProductDetailBLL addobj = new ProductDetailBLL();
                addobj.Add(obj);

            }
            catch (Exception)
            {

                throw;
            }

        }


        public void loadData()
        {

            try
            {

                DataSet getDsVal = new DataSet();

                ProductDetail obj = new ProductDetail();
                obj.ProductDetailID = Convert.ToInt32(Request.QueryString["detaiiId"]);
                getDsVal = ProductDetailBLL.GetProductDetailByDetailID(obj);

                if (getDsVal != null)
                {
                    txtQuantityUnit.Text = getDsVal.Tables[0].Rows[0]["QuantityUnit"].ToString();
                    txtDiscount.Text = getDsVal.Tables[0].Rows[0]["Discount"].ToString();
                    txtSalePrice.Text = getDsVal.Tables[0].Rows[0]["SalePrice"].ToString();
                    txtDateExpired.Text = getDsVal.Tables[0].Rows[0]["DateExpired"].ToString();
                    drpProductMaster.SelectedValue = getDsVal.Tables[0].Rows[0]["ProductID"].ToString();
                    txtCostPrice.Text = getDsVal.Tables[0].Rows[0]["CostPrice"].ToString();
                    txtStatus.Text = getDsVal.Tables[0].Rows[0]["Status"].ToString();
                    DateCreated = Convert.ToDateTime(getDsVal.Tables[0].Rows[0]["DateCreated"].ToString()).Date;
                    DateUpdated = Convert.ToDateTime(getDsVal.Tables[0].Rows[0]["DateUpdated"].ToString()).Date;
                    DateExpired = Convert.ToDateTime(getDsVal.Tables[0].Rows[0]["DateExpired"].ToString()).Date;
                }


            }
            catch (Exception)
            {

                throw;
            }


        }



        public void UpdateProductDetail()
        {
            try
            {
                ProductDetail obj = new ProductDetail();
                obj.ProductDetailID = Convert.ToInt32(Request.QueryString["detaiiId"]);
                obj.ProductMasterID = Convert.ToInt32(drpProductMaster.SelectedValue);
                obj.Quantity = float.Parse(txtQuantityUnit.Text);
                obj.CostPrice = float.Parse(txtCostPrice.Text);
                obj.SalePrice = float.Parse(txtSalePrice.Text);
                obj.Discount = (txtDiscount.Text);
                obj.Status = txtStatus.Text;
                obj.DateCreated = DateTime.Now; //DateCreated.Date;
                obj.DateUpdated = DateTime.Now;// DateUpdated.Date;
                obj.DateExpired = DateTime.Now.AddDays(1000);//DateExpired.Date;

                ProductDetailBLL updobj = new ProductDetailBLL();
                updobj.Update(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}