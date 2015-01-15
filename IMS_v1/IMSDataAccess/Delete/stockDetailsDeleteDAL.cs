using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
  public   class stockDetailsDeleteDAL:DataAccessbase
  {
      stockDetailsDeleteDALDataParameters _insertParameters;
      public stockDetailsDeleteDAL()
      {

      }
       public void Delete(StockDetails val)
        {
            _insertParameters = new stockDetailsDeleteDALDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }


  public class stockDetailsDeleteDALDataParameters { 
       private StockDetails _stockDetails;


       public stockDetailsDeleteDALDataParameters(StockDetails stockdetails)
        {
            stockdetails = _stockDetails;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_ProductID", StockDetails.ProductID) };
            Parameters = parameters;
        }
        public StockDetails StockDetails
        {
            get { return _stockDetails; }
            set { _stockDetails = value; }
        }
        private SqlParameter[] _parameters;

        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

    }
  
  }

