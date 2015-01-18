using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class DepartmentSelectByCategoryNameDAL:DataAccessbase
    {
         CategorySelectDataParameters _insertParameters;

        public DepartmentSelectByCategoryNameDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetAllDepPerCategoryName.ToString();
        }

        public DataSet View(Category dep)
        {
            DataSet ds;
            _insertParameters = new CategorySelectDataParameters(dep,true);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds=dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
            return ds;
        }
    }


}
