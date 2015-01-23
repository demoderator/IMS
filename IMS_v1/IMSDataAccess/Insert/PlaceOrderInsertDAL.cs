using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class PlaceOrderInsertDAL : DataAccessbase
    {
        PlaceOrderInsertDALDataParameters _insertParameters;
        public PlaceOrderInsertDAL()
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_PalceeNewOrder.ToString();
        }
        public void Add(OrderDetails det)
        {

            _insertParameters = new PlaceOrderInsertDALDataParameters(det);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }

    public class PlaceOrderInsertDALDataParameters
    {
        private OrderDetails _department;
        private SqlParameter[] _parameters;

        public PlaceOrderInsertDALDataParameters(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {   new SqlParameter("@p_OrderDate", OrderDetails.CostPrice), 
                                            new SqlParameter("@p_OrderAmount", OrderDetails.CostPrice), 
                                            new SqlParameter("@p_UserID", OrderDetails.CostPrice), 
                                            new SqlParameter("@p_OrderStatus", OrderDetails.CostPrice), 
                                            new SqlParameter("@p_OrderRequestBy", OrderDetails.CostPrice), 
                                            new SqlParameter("@p_OrderRequestedFor", OrderDetails.CostPrice), 
                                            new SqlParameter("@p_OrderTypeID", OrderDetails.Discount) 
                                             
                                            
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
