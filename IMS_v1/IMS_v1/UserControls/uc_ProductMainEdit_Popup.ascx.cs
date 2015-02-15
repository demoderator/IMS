using AjaxControlToolkit;
using IMSBusinessLogic;
using IMSCommon;
using IMSCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1.UserControls
{
    public partial class uc_ProductMainEdit_Popup : System.Web.UI.UserControl
    {
        private ProductMaster _currentSource;
        private bool _isAdd;

        private System.Delegate _closeParam;
        public Delegate CloseParam
        {
            set { _closeParam = value; }
        }

        //public delegate void EventHandler(object sender, EventArgs e);
        //public event EventHandler CustomerCreated;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public ProductMaster CurrentSource
        {
            get { return _currentSource; }
            set 
            {
                _currentSource = value;
                txtProductName.Text = _currentSource.ProductName;
                txtProductID.Text = _currentSource.ProductID.ToString();
                prodID.Visible = false;
                txtDescription.Text = _currentSource.ProductDescription;
                txtBrndName.Text = _currentSource.Manufacturer;
                txtCP.Text = _currentSource.CostPrice.ToString();
                txtSP.Text = _currentSource.SalePrice.ToString();
                txtDescription.Text = _currentSource.Description;
                TxtDisc.Text = _currentSource.MaxDiscount.ToString();
                txtGName.Text = _currentSource.GenericName;
                txtMeasQty.Text = _currentSource.MeasureQuantity;
                txtMeasType.Text = _currentSource.MeasureType;
                txtProdOrgID.Text = _currentSource.ProductOrgID;
                txtProdType.Text = _currentSource.ProductType;
                txtQUnit.Text = _currentSource.QuanityUnit.ToString();
                txtProdCode.Text = _currentSource.ProductCode;
                txtThreshold.Text = _currentSource.ThreshHold.ToString();
                drpcategory.Items.Insert(0, new ListItem("Select Sub-Category", ""));
                drpcategory.DataSource = SubCategoryBLL.GetAllSubCategories();
                drpcategory.DataValueField = "subCatID";
                drpcategory.DataTextField = "subCatName";
                drpcategory.DataBind();
            }
        }

        public bool IsAdd
        {
            get { return _isAdd; }
            set 
            {
                if (value)
                {
                    SaveVal.Visible = false;
                    AddBtn.Visible = true;
                }
                else
                {
                    AddBtn.Visible = false;
                    SaveVal.Visible = true;
                }
                _isAdd = value; 
            }
        }
      
        protected void SaveVal_Click(object sender, EventArgs e)
        {
            AddEditMasterProduct(false);
        }

        public void AddEditMasterProduct(bool add)
        {
            try
            {
                ProductMaster obj = new ProductMaster();
               
                obj.ProductName = txtProductName.Text;
                obj.ProductCode = txtProdCode.Text;
                obj.Manufacturer= txtBrndName.Text;
                obj.Status = "1";
                obj.ProductDescription=txtDescription.Text;
                obj.GenericName=txtGName.Text;
                obj.MeasureQuantity=txtMeasQty.Text;
                obj.MeasureType = txtMeasType.Text;
                obj.ProductOrgID=txtProdOrgID.Text;
                obj.ProductType=txtProdType.Text;
                float res1, res2;
                    int res3,res4;

                if (float.TryParse(txtCP.Text.ToString(), out res1))
                {
                    obj.CostPrice = res1;
                }
                else 
                {
                    WebMessageBoxUtil.Show("Invalid input of Cost Price");
                    return;
                }

                if (float.TryParse(txtSP.Text.ToString(), out res2))
                {
                    obj.SalePrice = res2;
                }
                else
                {
                    WebMessageBoxUtil.Show("Invalid input of Sale Price");
                    return;
                }
                if (int.TryParse(TxtDisc.Text.ToString(), out res3))
                {
                    obj.MaxDiscount = res3;
                }
                else
                {
                    WebMessageBoxUtil.Show("Invalid input of Discount");
                    return;
                }


                if (int.TryParse(txtQUnit.Text.ToString(), out res4))
                {
                    obj.QuanityUnit = res4;
                }
                else
                {
                    WebMessageBoxUtil.Show("Invalid input of Quantity Unit");
                    return;
                }           
             
                obj.SubCategoryID = Convert.ToInt32(drpcategory.SelectedValue);
             
                obj.ProductCode = txtProdCode.Text;
                int thd;
                if (int.TryParse(txtThreshold.Text, out thd))
                {
                    obj.ThreshHold = thd;
                }
                else
                {
                    WebMessageBoxUtil.Show("Invalid input of threshold");
                    return;
                }
                obj.LastUpdatedDate = DateTime.Now;
                ProductMasterBLL objupd = new ProductMasterBLL();
                if (add)
                {
                    obj.DateCreated = DateTime.Now;
                    objupd.Add(obj);
                }
                else
                {

                    obj.ProductID = int.Parse(txtProductID.Text);
                    objupd.Update(obj);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
          
            _closeParam.DynamicInvoke();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditMasterProduct(true);
        }
        //}
    }
}