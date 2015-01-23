using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class OrderDetailsByOrderID :DataAccessbase
    {
        OrderDetailsByOrderIDDataparameters _insertParameters;

        public OrderDetailsByOrderID()
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetOrderDetails.ToString();

        }

        public DataSet View(OrderDetails val)
        {
            DataSet ds;
            _insertParameters = new OrderDetailsByOrderIDDataparameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
            return ds;
        }
    }

    public class OrderDetailsByOrderIDDataparameters
    {


        private OrderDetails _department;
        private SqlParameter[] _parameters;

        public OrderDetailsByOrderIDDataparameters(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {   new SqlParameter("@p_OrderID", OrderDetails.OrderID), 
                                         
                                             
                                            
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
