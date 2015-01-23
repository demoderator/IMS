using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class OrderDetailsUpdateByStatusDAL : DataAccessbase
    {
        OrderDetailsUpdateByStatusDALDataParameters _insertParameters;
        public OrderDetailsUpdateByStatusDAL()
        {
            StoredProcedureName = StoredProcedure.Update.Sp_AddRecivedOrderDetails.ToString();



        }

        public void Update(OrderDetails val)
        {

            _insertParameters = new OrderDetailsUpdateByStatusDALDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }


    public class OrderDetailsUpdateByStatusDALDataParameters
    {


        private OrderDetails _department;
        private SqlParameter[] _parameters;

        public OrderDetailsUpdateByStatusDALDataParameters(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@p_orderDetailID", OrderDetails.OrderDetailID), 
                                            new SqlParameter("@p_StatusDetails", OrderDetails.StatusDetails), 
                                             new SqlParameter("@p_Description", OrderDetails.OrderDescription), 
                                              new SqlParameter("@p_SalePrice", OrderDetails.SalePrice), 
                                               new SqlParameter("@p_ExpiryDate", OrderDetails.ExpiryDate), 
                                                new SqlParameter("@p_ReceivedDate", OrderDetails.ReceivedDate), 
                                                 new SqlParameter("@p_ReceivedQuantity", OrderDetails.ReceivedQuantity), 
                                                  new SqlParameter("@p_RoleType", OrderDetails.RoleType),
                                                  new SqlParameter("@p_ProductDetailId", OrderDetails.ProductDetailId)
                                                 
                                                 
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
