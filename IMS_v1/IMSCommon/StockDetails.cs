using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSCommon
{
   public class StockDetails
    {
        #region fields

        long stockID;

        public long StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }
        long productID;

        public long ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        float quantity;

        public float Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        DateTime dateCreated;

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        DateTime dateUpdated;

        public DateTime DateUpdated
        {
            get { return dateUpdated; }
            set { dateUpdated = value; }
        }


        long userRoleID;

        public long UserRoleID
        {
            get { return userRoleID; }
            set { userRoleID = value; }
        }
        #endregion
    }
}
