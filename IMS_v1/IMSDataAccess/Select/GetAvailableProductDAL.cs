﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class GetAvailableProductDAL : DataAccessbase
    {



        public GetAvailableProductDAL()
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetAvailableProduct.ToString();
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
