using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class DepartmentSelectDAL:DataAccessbase
    {
        private IMSCommon.Department _department;

        public DepartmentSelectDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetDepartmentList.ToString();
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
