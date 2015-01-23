using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
  public  class PendingOrderDAL:DataAccessbase
    {
      PendingOrderDALDataParameters _insertParameters;
      public PendingOrderDAL()
      {
          StoredProcedureName = StoredProcedure.Select.Sp_GetPendingOrderDetails.ToString();
      }
      public DataSet View(OrderDetails val)
      {
          DataSet ds;
          _insertParameters = new PendingOrderDALDataParameters(val);
          DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
          ds = dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
          return ds;
      }

    }

  public class PendingOrderDALDataParameters
  {


       private OrderDetails _department;
        private SqlParameter[] _parameters;

        public PendingOrderDALDataParameters(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {   new SqlParameter("@p_OrderRequestBy", OrderDetails.OrderRequestBy), 
                                         
                                             new SqlParameter("@p_OrderRequestedFor", OrderDetails.OrderRequestedFor),


                                             new SqlParameter("@P_OrderID", OrderDetails.OrderID),
                                              new SqlParameter("@p_OrderMode", OrderDetails.OrderMode)
                                             

                                             
                                            
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
