using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
  public   class orderDetailByDetailsIdDeleteDAL:DataAccessbase
    {

      orderDetailByDetailsIdDeleteDALDataParameters _insertParameters;
      public orderDetailByDetailsIdDeleteDAL() 
      {
          StoredProcedureName = StoredProcedure.Delete.Sp_DeleteOrderDetailByOrderDetailId.ToString();
      }

      public void Delete(OrderDetails val)
      {

          _insertParameters = new orderDetailByDetailsIdDeleteDALDataParameters(val);
          DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
          dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
      }


    }


    public class orderDetailByDetailsIdDeleteDALDataParameters
    {
    
    
     private OrderDetails _department;
        private SqlParameter[] _parameters;

        public orderDetailByDetailsIdDeleteDALDataParameters(OrderDetails det)
        {
            OrderDetails = det;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {   new SqlParameter("@p_orderDetailID", OrderDetails.OrderDetailID), 
                                          
                                            
                                             
                                            
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
