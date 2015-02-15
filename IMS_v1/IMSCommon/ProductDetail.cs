using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSCommon
{
    public class ProductDetail
    {
        #region fields
        int productDetailID;
        //float quantity;
        //string discount;
        float salePrice;
        float costPrice;
        int status;
        DateTime dateExpired;
        DateTime dateCreated;
        DateTime dateUpdated;
        int productMasterID;
        
       
       

        #endregion

        public ProductDetail() { }

        #region properties

        public int ProductDetailID
        {
            get { return productDetailID; }
            set { productDetailID = value; }
        }
        //public float Quantity
        //{
        //    get { return quantity; }
        //    set { quantity = value; }
        //}


        //public string Discount
        //{
        //    get { return discount; }
        //    set { discount = value; }
        //}

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }


        public float CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }


        public DateTime DateExpired
        {
            get { return dateExpired; }
            set { dateExpired = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public DateTime DateUpdated
        {
            get { return dateUpdated; }
            set { dateUpdated = value; }
        }

        public int ProductMasterID
        {
            get { return productMasterID; }
            set { productMasterID = value; }
        }
        #endregion
    }
}
