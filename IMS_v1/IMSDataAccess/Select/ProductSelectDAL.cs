using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class ProductSelectDAL:DataAccessbase
    {
        public ProductSelectDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetProductList.ToString();
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
