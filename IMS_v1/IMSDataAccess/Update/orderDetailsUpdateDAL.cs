using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class orderDetailsUpdateDAL : DataAccessbase
    {

        orderDetailsUpdateDALDataParameters _insertParameters;
        public orderDetailsUpdateDAL()
        {
            StoredProcedureName = StoredProcedure.Update.Sp_UpdateOrderDetail.ToString();

        }
        public void Update(OrderDetails val)
        {

            _insertParameters = new orderDetailsUpdateDALDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }



    }


    public class orderDetailsUpdateDALDataParameters
    {

        private OrderDetails _department;
        private SqlParameter[] _parameters;

        public orderDetailsUpdateDALDataParameters(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {   new SqlParameter("@p_orderDetailID", OrderDetails.OrderDetailID), 
                                            new SqlParameter("@p_ProductID", OrderDetails.ProductID), 
                                            new SqlParameter("@p_OrderedQuantity", OrderDetails.OrderedQuantity),
                                             new SqlParameter("@p_SalePrice", OrderDetails.SalePrice),
                                             new SqlParameter("@p_CostPrice", OrderDetails.CostPrice)
                                           
                                             
                                            
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
