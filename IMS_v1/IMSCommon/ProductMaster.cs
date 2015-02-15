using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSCommon
{
    public class ProductMaster
    {
        #region fields
        
        int productID;
        string productName;
        string productDescription; 
        string brandName;
        string productType;
        string productSelection;
        string status;
        int subCategoryID;
        DateTime dateCreated;
        DateTime lastUpdatedDate;
        string genericName;
        string productOrgID;
        string measureQuantity;
        string measureType;
        int quanityUnit;
        string description;
        string control;
        string binNumber;
        string productCode;
        int maxDiscount;
        string expiry;
        int lineID;
        int threshHold;
        //string userID;
        float salePrice;
        float costPrice;
              
        #endregion

        public ProductMaster() { }

        #region Properties

        public string MeasureQuantity
        {
            get { return measureQuantity; }
            set { measureQuantity = value; }
        }

        public string MeasureType
        {
            get { return measureType; }
            set { measureType = value; }
        }

        public int QuanityUnit
        {
            get { return quanityUnit; }
            set { quanityUnit = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Control
        {
            get { return control; }
            set { control = value; }
        }

        public string BinNumber
        {
            get { return binNumber; }
            set { binNumber = value; }
        }

        public int MaxDiscount
        {
            get { return maxDiscount; }
            set { maxDiscount = value; }
        }

        public string Expiry
        {
            get { return expiry; }
            set { expiry = value; }
        }

        public int LineID
        {
            get { return lineID; }
            set { lineID = value; }
        }

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
        public string GenericName
        {
            get { return genericName; }
            set { genericName = value; }
        }

        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        public string ProductOrgID
        {
            get { return productOrgID; }
            set { productOrgID = value; }
        }



        public int ThreshHold
        {
            get { return threshHold; }
            set { threshHold = value; }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
      

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        public string ProductSelection
        {
            get { return productSelection; }
            set { productSelection = value; }
        }

        public int SubCategoryID
        {
            get { return subCategoryID; }
            set { subCategoryID = value; }
        }

      

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }


        public DateTime LastUpdatedDate
        {
            get { return lastUpdatedDate; }
            set { lastUpdatedDate = value; }
        }
       

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }


        public string Manufacturer
        {
            get { return brandName; }
            set { brandName = value; }
        }
        #endregion
    }
}
