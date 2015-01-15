using IMSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMSBusinessLogic;
using System.Data;

namespace IMS_v1
{
    public partial class AddEditVendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (Request.QueryString["Id"] != null)
                {
                    LoadData();
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {


                if (Request.QueryString["Id"] != null)
                {
                    UpdateVendor();
                }
                else
                {
                    AddVendor();

                }

                Response.Redirect("VendorList.aspx");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void AddVendor()
        {
            try
            {


                Vendor obj = new Vendor();

                obj.supp_ID = txtVendorName.Text;
                obj.SupName = txtVendorName.Text;
                obj.Email = txtEmail.Text;
                obj.city = txtcity.Text;
                obj.State = txtState.Text;
                obj.Country = txtCounty.Text;
                obj.address = txtaddress.Text;
                obj.ConPerson = txtConPerson.Text;
                obj.Credit = txtCredit.Text;
                obj.Discount = txtDiscount.Text;
                obj.Fax = txtfax.Text;
                obj.Phone = txtphone.Text;
                obj.Mobile = txtmobile.Text;
                obj.Pager = txtpager.Text;
                obj.Pincode = txtPincode.Text;
                obj.LineID = Convert.ToInt32(txtLineIdk.Text);
                obj.DateCreated = DateTime.Now;
                VendorBll objAdd = new VendorBll();
                objAdd.Add(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void LoadData()
        {
            try
            {


                DataSet ds = new DataSet();
                Vendor obj = new Vendor();

                obj.supp_ID = Request.QueryString["Id"].ToString();
                ds = VendorBll.GetAllVendorById(obj);


                //    ds.Tables[0].Rows[0]["Supp_ID"].ToString();
                //  txtVendorName.Text = ds.Tables[0].Rows[0]["Supp_ID"].ToString();
                txtVendorName.Text = ds.Tables[0].Rows[0]["SupName"].ToString();
                txtaddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                txtcity.Text = ds.Tables[0].Rows[0]["City"].ToString();
                txtState.Text = ds.Tables[0].Rows[0]["State"].ToString();
                txtCounty.Text = ds.Tables[0].Rows[0]["Country"].ToString();
                txtPincode.Text = ds.Tables[0].Rows[0]["Pincode"].ToString();
                txtphone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                txtfax.Text = ds.Tables[0].Rows[0]["Fax"].ToString();
                txtmobile.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
                txtpager.Text = ds.Tables[0].Rows[0]["Pager"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                txtConPerson.Text = ds.Tables[0].Rows[0]["ConPerson"].ToString();
                txtDiscount.Text = ds.Tables[0].Rows[0]["Discount"].ToString();
                txtCredit.Text = ds.Tables[0].Rows[0]["Credit"].ToString();
                txtLineIdk.Text = ds.Tables[0].Rows[0]["LineID"].ToString();


            }
            catch (Exception)
            {

                throw;
            }

        }



        public void UpdateVendor()
        {
            try
            {


                Vendor obj = new Vendor();

                obj.supp_ID = Request.QueryString["Id"].ToString();
                obj.SupName = txtVendorName.Text;
                obj.Email = txtEmail.Text;
                obj.city = txtcity.Text;
                obj.State = txtState.Text;
                obj.Country = txtCounty.Text;
                obj.address = txtaddress.Text;
                obj.ConPerson = txtConPerson.Text;
                obj.Credit = txtCredit.Text;
                obj.Discount = txtDiscount.Text;
                obj.Fax = txtfax.Text;
                obj.Phone = txtphone.Text;
                obj.Mobile = txtmobile.Text;
                obj.Pager = txtpager.Text;
                obj.Pincode = txtPincode.Text;
                obj.LineID = Convert.ToInt32(txtLineIdk.Text);
                obj.DateCreated = DateTime.Now;
                VendorBll objUpdate = new VendorBll();
                objUpdate.Update(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}