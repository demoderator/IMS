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
    public partial class AddEditMasterProduct : System.Web.UI.Page
    {
        private DataSet ds;
        ProductMaster obj = new ProductMaster();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                if (Request.QueryString["id"] != null)
                {
                    LoadData(Convert.ToInt64(Request.QueryString["id"]));
                }
                BinddrpCatogory();
            }
        }

        public void BinddrpCatogory()
        {
            DataSet ds2 = new DataSet();
            ds2 = SubCategoryBLL.GetAllSubCategories();
            drpcategory.Items.Insert(0, new ListItem("Select Category", ""));
            drpcategory.DataSource = ds2;
            drpcategory.DataValueField = "subCatID";
            drpcategory.DataTextField = "subCatName";
            drpcategory.DataBind();
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                UpdateMasterProduct(Convert.ToInt64(Request.QueryString["id"]));
            }

            else
            {
                AddProductMaster();
            }

            Response.Redirect("AddEditProducts.aspx");

        }

        public void AddProductMaster()
        {
            try
            {
                ProductMaster obj = new ProductMaster();
                obj.ProductName = txtProductName.Text;
                obj.ProductDescription = txtDescription.Text;
                obj.Status = txtStatus.Text;
                obj.Manufacturer = txtManufacturer.Text;
                obj.GreenRainCode = txtGreenRainCode.Text;
                obj.Pack = Convert.ToInt32(txtPack.Text);
                obj.UnitSize = Convert.ToInt32(txtUnitSize.Text);
                obj.WUnit = txtWunit.Text;
                obj.ProductType = txtProductType.Text;
                obj.ProductSelection = txtProductSelection.Text;
                obj.SubCategoryID = Convert.ToInt32(drpcategory.SelectedValue);
                obj.LastOrderDate = DateTime.Now;
                obj.DateCreated = DateTime.Now;
                obj.Upc = "100";
                obj.ProductCode = "20";
                obj.ThreshHold = 500;
                obj.LastUpdatedDate = DateTime.Now;
                ProductMasterBLL add = new ProductMasterBLL();
                add.Add(obj);



            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void LoadData(long id)
        {
            try
            {

                obj.ProductID = Convert.ToInt32(Request.QueryString["id"]);
                ds = ProductMasterBLL.GetProductMasterByID(obj);
                // DS.Tables[<tablename>].Rows[<rowID>].ItemArray[<ColumnIndex>].ToString();
                // ds.Tables[0].Rows[0]["ProductName"].ToString();
                //ds.Tables[0].Rows[0].ItemArray[9].ToString();
                txtProductName.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
                txtDescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                txtStatus.Text = ds.Tables[0].Rows[0]["Status"].ToString();
                txtManufacturer.Text = ds.Tables[0].Rows[0]["Manufacturer"].ToString();
                txtGreenRainCode.Text = ds.Tables[0].Rows[0]["GreenRainCode"].ToString();
                txtPack.Text = ds.Tables[0].Rows[0]["Pack"].ToString();
                txtUnitSize.Text = ds.Tables[0].Rows[0]["UnitSize"].ToString();
                txtWunit.Text = ds.Tables[0].Rows[0]["WUnit"].ToString();
                txtProductType.Text = ds.Tables[0].Rows[0]["ProductType"].ToString();
                txtProductSelection.Text = ds.Tables[0].Rows[0]["ProductSelection"].ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateMasterProduct(long id)
        {
            try
            {
                ProductMaster obj = new ProductMaster();
                obj.ProductID = Convert.ToInt32(Request.QueryString["id"]);
                obj.ProductName = txtProductName.Text;
                obj.ProductDescription = txtDescription.Text;
                obj.Status = txtStatus.Text;
                obj.Manufacturer = txtManufacturer.Text;
                obj.GreenRainCode = txtGreenRainCode.Text;
                obj.Pack = Convert.ToInt32(txtPack.Text);
                obj.UnitSize = Convert.ToInt32(txtUnitSize.Text);
                obj.WUnit = txtWunit.Text;
                obj.ProductType = txtProductType.Text;
                obj.ProductSelection = txtProductSelection.Text;
                obj.SubCategoryID = Convert.ToInt32(drpcategory.SelectedValue);
                obj.LastOrderDate = DateTime.Now;
                obj.DateCreated = DateTime.Now;
                obj.Upc = "100";
                obj.ProductCode = "20";
                obj.ThreshHold = 500;
                obj.LastUpdatedDate = DateTime.Now;
                ProductMasterBLL objupd = new ProductMasterBLL();
                objupd.Update(obj);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}