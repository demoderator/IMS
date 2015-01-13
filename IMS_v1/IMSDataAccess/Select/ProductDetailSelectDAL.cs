using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class ProductDetailSelectDAL:DataAccessbase
    {
        public ProductDetailSelectDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetProduct_Detail.ToString();
        }

        public DataSet View(ProductDetail val)
        {
            DataSet ds;
          
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString);
            return ds;
        }
    }
}
