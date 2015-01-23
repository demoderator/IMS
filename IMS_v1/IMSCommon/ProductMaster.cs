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
        string manufacturer;
        string greenRainCode;
        int pack;
        int threshHold;
        float unitSize;
        string wUnit;
        string productType;
        string productSelection;
        string upc;
        string productCode;
        string status;
        int subCategoryID;
        DateTime lastOrderDate;
        DateTime dateCreated;
        DateTime lastUpdatedDate;
        string genericName;

      
        #endregion

        public ProductMaster() { }

        #region Properties
        public string GenericName
        {
            get { return genericName; }
            set { genericName = value; }
        }
 
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string WUnit
        {
            get { return wUnit; }
            set { wUnit = value; }
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

        public string Upc
        {
            get { return upc; }
            set { upc = value; }
        }

        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        public int SubCategoryID
        {
            get { return subCategoryID; }
            set { subCategoryID = value; }
        }

        public DateTime LastOrderDate
        {
            get { return lastOrderDate; }
            set { lastOrderDate = value; }
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
        public string GreenRainCode
        {
            get { return greenRainCode; }
            set { greenRainCode = value; }
        }

        public int Pack
        {
            get { return pack; }
            set { pack = value; }
        }

        public int ThreshHold
        {
            get { return threshHold; }
            set { threshHold = value; }
        }


        public float UnitSize
        {
            get { return unitSize; }
            set { unitSize = value; }
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
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        #endregion
    }
}
