using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class OrderInsertDetail : DataAccessbase
    {
        OrderInsertDetailDataparameter _insertParameters;

        public OrderInsertDetail()
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_AddOrderDetails.ToString();

        }
        public void Add(OrderDetails det)
        {

            _insertParameters = new OrderInsertDetailDataparameter(det);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }


    }


    public class OrderInsertDetailDataparameter
    {
        private OrderDetails _department;
        private SqlParameter[] _parameters;

        public OrderInsertDetailDataparameter(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {   new SqlParameter("@p_OrderID", OrderDetails.OrderID), 
                                            new SqlParameter("@p_ProductID", OrderDetails.ProductID), 
                                            new SqlParameter("@p_OrderDate", OrderDetails.OrderDate), 
                                            new SqlParameter("@p_OrderedQuantity", OrderDetails.OrderedQuantity), 
                                            new SqlParameter("@p_StatusDetails", OrderDetails.StatusDetails),
                                               new SqlParameter("@p_SalePrice", OrderDetails.SalePrice),
                                                  new SqlParameter("@p_Description", OrderDetails.OrderDescription)
                                            
                                             
                                            
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

