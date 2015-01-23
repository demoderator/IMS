using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class GetPlaceOrderDAL : DataAccessbase
    {
        GetPlaceOrderDALDataParameters _insertParameters;

        public GetPlaceOrderDAL()
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_PalceeNewOrder.ToString();
        }
        public DataSet View(OrderDetails val)
        {
            DataSet ds;
            _insertParameters = new GetPlaceOrderDALDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
            return ds;
        }

    }

    public class GetPlaceOrderDALDataParameters
    {

        private OrderDetails _department;
        private SqlParameter[] _parameters;

        public GetPlaceOrderDALDataParameters(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {   new SqlParameter("@p_OrderDate", OrderDetails.OrderDate), 
                                            new SqlParameter("@p_OrderAmount", OrderDetails.OrderAmount), 
                                            new SqlParameter("@p_UserID", OrderDetails.UserID), 
                                            new SqlParameter("@p_OrderStatus", OrderDetails.OrderStatus), 
                                            new SqlParameter("@p_OrderRequestBy", OrderDetails.OrderRequestBy), 
                                            new SqlParameter("@p_OrderRequestedFor", OrderDetails.OrderRequestedFor), 
                                            new SqlParameter("@p_OrderTypeID", OrderDetails.OrderTypeID) ,
                                            new SqlParameter("@p_OrderMode", OrderDetails.OrderMode),

                                             new SqlParameter("@p_VendorID", OrderDetails.VendorID)
                                            
                                        };
            Parameters = parameters;
        }
        public SqlParameter[] Parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        public OrderDetails OrderDetails
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }


    }

}

