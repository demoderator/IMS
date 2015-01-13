using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class ProductMasterSelectDAL:DataAccessbase
    {
        public ProductMasterSelectDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetProductMaster.ToString();
        }

        public DataSet View()
        {
            DataSet ds;
          
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString);
            return ds;
        }
    }

    
}
