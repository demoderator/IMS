﻿using IMSCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class DisplayStockDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gdvDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gdvDetails_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        public void BindGrid()
        {
            //DataSet ds = new DataSet();

            //ProductDetail objdrp = new ProductDetail();
            //currentId = int.Parse(Session["prod_ID"].ToString());
            //objdrp.ProductMasterID = currentId;

            //ds = ProductDetailBLL.GetProductDetailByID(objdrp);
            //gdvDetails.DataSource = ds;
            //gdvDetails.DataBind();
        }

        protected void gdvDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvDetails.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void gdvDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //try
            //{
            //    if (e.CommandName.Equals("UpdateDep"))
            //    {
            //        Label ID = (Label)gdvDetails.Rows[gdvDetails.EditIndex].FindControl("lblProd_Id");
            //        TextBox SP = (TextBox)gdvDetails.Rows[gdvDetails.EditIndex].Cells[0].FindControl("txtSP");

            //        TextBox CP = (TextBox)gdvDetails.Rows[gdvDetails.EditIndex].FindControl("txtCP");
            //        TextBox Discount = (TextBox)gdvDetails.Rows[gdvDetails.EditIndex].FindControl("txtDiscount");
            //        ProductDetail objdrp = new ProductDetail();
            //        objdrp.ProductDetailID = int.Parse(ID.Text);

            //        float res;
            //        if (float.TryParse(SP.Text, out res))
            //        {
            //            objdrp.SalePrice = res;
            //            float res2;
            //            if (float.TryParse(CP.Text, out res2))
            //            {
            //                objdrp.CostPrice = res2;
            //                float res3;
            //                if (float.TryParse(Discount.Text, out res3))
            //                {
            //                    objdrp.Discount = Discount.Text;
            //                    objdrp.DateUpdated = DateTime.Now;

            //                    ProductDetailBLL sdBLL = new ProductDetailBLL();
            //                    sdBLL.Update(objdrp);

            //                }
            //                else
            //                {
            //                    WebMessageBoxUtil.Show("Invalid input in Discount field ");
            //                }
            //            }
            //            else
            //            {
            //                WebMessageBoxUtil.Show("Invalid input in Cost Price field ");
            //            }
            //        }
            //        else
            //        {
            //            WebMessageBoxUtil.Show("Invalid input in Sale Price field ");
            //        }



            //    }
            //}
            //catch (Exception exp) { }
            //finally
            //{
            //    gdvDetails.EditIndex = -1;
            //    BindGrid();
            //}
        }

        protected void gdvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //try
            //{
            //    Label ID = (Label)gdvDetails.Rows[e.RowIndex].FindControl("lblProd_Id");
            //    ProductDetail objdrp = new ProductDetail();
            //    objdrp.ProductDetailID = int.Parse(ID.Text);
            //    ProductDetailBLL sdBLL = new ProductDetailBLL();
            //    sdBLL.Delete(objdrp);
            //}
            //catch (Exception exp) { }
            //finally
            //{
            //    gdvDetails.EditIndex = -1;
            //    BindGrid();
            //}
        }

        protected void gdvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvDetails.EditIndex = -1;
            BindGrid();
        }
    }
}