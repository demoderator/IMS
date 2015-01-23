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
               
                txtGreenRainCode.Text = _currentSource.GreenRainCode;
                txtManufacturer.Text = _currentSource.Manufacturer;
                txtGreenRainCode.Text = _currentSource.GreenRainCode;
                txtPack.Text = _currentSource.Pack.ToString();
                txtUnitSize.Text = _currentSource.UnitSize.ToString();
                txtWunit.Text = _currentSource.WUnit;
                txtProductType.Text =_currentSource.ProductType;
                txtProductSelection.Text = _currentSource.ProductSelection;
                txtUPC.Text = _currentSource.Upc;
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
                obj.ProductDescription = txtDescription.Text;
                obj.Status = "1";
                obj.Manufacturer = txtManufacturer.Text;
                obj.GreenRainCode = txtGreenRainCode.Text;
                int pck, us;
                if (int.TryParse(txtPack.Text, out pck))
                {
                    obj.Pack = pck;
                    if (int.TryParse(txtUnitSize.Text, out us))
                    {
                        obj.UnitSize = us;
                    }
                    else
                    {
                        WebMessageBoxUtil.Show("Invalid input value for unit size");
                        return;
                    }
                }
                else
                {
                    WebMessageBoxUtil.Show("Invalid input value for Pack");
                    return;
                }

                obj.LastUpdatedDate = DateTime.Now;
                obj.WUnit = txtWunit.Text;
                obj.ProductType = txtProductType.Text;
                obj.ProductSelection = txtProductSelection.Text;
                obj.SubCategoryID = Convert.ToInt32(drpcategory.SelectedValue);
                obj.Upc = txtUPC.Text;
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