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
    public partial class ListProductDetail : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProMasid"] != null)
                {
                    BindgdvlistProductDetail();

                }
            }
        }


        public void BindgdvlistProductDetail()
        {
            if (Request.QueryString["ProMasid"] != null)
            {
                ProductDetail obj = new ProductDetail();
                obj.ProductMasterID = Convert.ToInt32(Request.QueryString["ProMasid"]);
                ds = ProductDetailBLL.GetProductDetailByID(obj);
                gdvlistProductDetail.DataSource = ds;
                gdvlistProductDetail.DataBind();
            }
        }
    }
}