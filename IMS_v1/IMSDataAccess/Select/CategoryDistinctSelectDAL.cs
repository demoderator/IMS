using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class CategoryDistinctSelectDAL:DataAccessbase
    {
        CategorySelectDataParameters _insertParameters;
        public CategoryDistinctSelectDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetDistinctCategories.ToString();
        }

        public DataSet View()
        {
            DataSet ds; 
            
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds=dbHelper.Run(base.ConnectionString);
            return ds;
        }
    }
}
