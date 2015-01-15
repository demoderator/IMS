using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
   public  class stockDetailsSelectDAL:DataAccessbase
    {
       public stockDetailsSelectDAL()
       {
           StoredProcedureName = StoredProcedure.Select.Sp_GetStockDetails.ToString();
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
