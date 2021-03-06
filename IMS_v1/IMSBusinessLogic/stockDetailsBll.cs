﻿using IMSCommon;
using IMSDataAccess.Delete;
using IMSDataAccess.Insert;
using IMSDataAccess.Select;
using IMSDataAccess.Update;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSBusinessLogic
{
 public class stockDetailsBll
    {

     public static DataSet GetStockDetailSearch(StockDetails val)
     {
         DataSet resultSet = new DataSet();
         StockDetailSearchDAL instance = new StockDetailSearchDAL();
         resultSet = instance.View(val);
         return resultSet;
     }

     public static DataSet GetStockDetailSearchExpiry(StockDetails val)
     {
         DataSet resultSet = new DataSet();
         StockExpiryDetailsDal instance = new StockExpiryDetailsDal();
         resultSet = instance.View(val);
         return resultSet;
     }

     public void Update(StockDetails val)
     {
         stockDetailsUpdateDAL instance = new stockDetailsUpdateDAL();
         instance.Update(val);
     }


     public void Delete(StockDetails val)
     {
         stockDetailsDeleteDAL instance = new stockDetailsDeleteDAL();
         instance.Delete(val);
     }

     public void Add(StockDetails val)
     {

         stock_DetailInsertDAL instance = new stock_DetailInsertDAL();
         instance.Add(val);

     }
    }
}
