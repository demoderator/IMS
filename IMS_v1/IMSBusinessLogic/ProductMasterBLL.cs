using IMSCommon;
using IMSDataAccess.Delete;
using IMSDataAccess.Select;
using IMSDataAccess.Update;
using IMSDataAccess.Insert;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSBusinessLogic
{
    public class ProductMasterBLL
    {
        public ProductMasterBLL() { }

        public static DataSet GetAllProductMaster() 
        {
            DataSet resultSet = new DataSet();
            ProductMasterSelectDAL instance = new ProductMasterSelectDAL();
            resultSet=instance.View();
            return resultSet;
        }

        public static DataSet GetProductMasterByID(ProductMaster val) 
        {
            DataSet resultSet = new DataSet();
            ProductMasterSelectByIdDAL instance = new ProductMasterSelectByIdDAL();
          
            resultSet = instance.View(val);
            return resultSet;
        }
        public void Update(ProductMaster val)
        {
            ProductMasterUpdateDAL instance = new ProductMasterUpdateDAL();
            instance.Update(val);
        }

        public void Delete(ProductMaster val)
        {
            ProductMasterDeleteDAL instance = new ProductMasterDeleteDAL();
            instance.Delete(val);
        }

        public void Add(ProductMaster val)
        {
            //ProductMasterInsertDAL instance = new ProductMasterInsertDAL();
            //instance.Delete(val);
        }
    }
}
