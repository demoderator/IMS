using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSCommon
{
    public class OrderDetails
    {

        String invoiceNum;

        public String InvoiceNumber
        {
            get { return invoiceNum; }
            set { invoiceNum = value; }
        }

        long orderDetailID;

        public long OrderDetailID
        {
            get { return orderDetailID; }
            set { orderDetailID = value; }
        }
        long orderID;

        public long OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        long productID;

        public long ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        string vendorID;

        public string VendorID
        {
            get { return vendorID; }
            set { vendorID = value; }
        }
        DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        DateTime receivedDate;

        public DateTime ReceivedDate
        {
            get { return receivedDate; }
            set { receivedDate = value; }
        }
        float orderedQuantity;

        public float OrderedQuantity
        {
            get { return orderedQuantity; }
            set { orderedQuantity = value; }
        }
        float receivedQuantity;

        public float ReceivedQuantity
        {
            get { return receivedQuantity; }
            set { receivedQuantity = value; }
        }
        float costPrice;

        public float CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }
        float salePrice;

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        float discount;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        DateTime expiryDate;

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }


        float orderAmount;

        public float OrderAmount
        {
            get { return orderAmount; }
            set { orderAmount = value; }
        }
        long userID;

        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string orderStatus;

        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }
        long orderRequestBy;

        public long OrderRequestBy
        {
            get { return orderRequestBy; }
            set { orderRequestBy = value; }
        }
        long orderRequestedFor;

        public long OrderRequestedFor
        {
            get { return orderRequestedFor; }
            set { orderRequestedFor = value; }
        }
        long orderTypeID;

        public long OrderTypeID
        {
            get { return orderTypeID; }
            set { orderTypeID = value; }
        }

        string statusDetails;

        public string StatusDetails
        {
            get { return statusDetails; }
            set { statusDetails = value; }
        }

        string orderDescription;

        public string OrderDescription
        {
            get { return orderDescription; }
            set { orderDescription = value; }
        }

        string roleType;

        public string RoleType
        {
            get { return roleType; }
            set { roleType = value; }
        }

        string orderMode;

        public string OrderMode
        {
            get { return orderMode; }
            set { orderMode = value; }
        }


        long productDetailId;

        public long ProductDetailId
        {
            get { return productDetailId; }
            set { productDetailId = value; }
        }
    }
}
