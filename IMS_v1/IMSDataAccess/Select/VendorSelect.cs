using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class VendorSelect : DataAccessbase
    {
        public VendorSelect()
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetVendor.ToString();
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
