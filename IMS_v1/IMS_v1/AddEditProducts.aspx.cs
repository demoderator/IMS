using IMSBusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class AddEditProducts : System.Web.UI.Page
    {
        private DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    try
            //    {

            //        BindGrid();
            //    }
            //    catch (Exception exp) { }
            //}
        }

        //protected void ProdDisplayGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    ProdDisplayGrid.PageIndex = e.NewPageIndex;
        //    BindGrid();
        //}

        //private void BindGrid()
        //{
        //    ds = ProductBLL.GetAllProducts();
        //    ProdDisplayGrid.DataSource = ds;
        //    ProdDisplayGrid.DataBind();
        //}
    }
}