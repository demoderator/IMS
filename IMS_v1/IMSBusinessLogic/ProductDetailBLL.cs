using IMSCommon;
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
    public class ProductDetailBLL
    {
         public ProductDetailBLL() { 
         
         
         }

         public static DataSet GetAllProductDetail() 
        {
            DataSet resultSet = new DataSet();
            ProductDetailSelectDAL instance = new ProductDetailSelectDAL();
            resultSet = instance.View();
            return resultSet;
        }

         public static DataSet GetProductDetailByID(ProductDetail val) 
        {
            DataSet resultSet = new DataSet();
            ProductDetailSelectByIdDAL instance = new ProductDetailSelectByIdDAL();
          resultSet=  instance.View(val);
            return resultSet;
        }

         public static DataSet GetProductDetailByDetailID(ProductDetail val)
         {
             DataSet resultSet = new DataSet();
             ProductDetailSelectByDetailIdDAL instance = new ProductDetailSelectByDetailIdDAL();
             resultSet = instance.View(val);
             return resultSet;
         }

        


         public void Update(ProductDetail val)
        {
            ProductDetailUpdateDAL instance = new ProductDetailUpdateDAL();
            instance.Update(val);
        }

         public void Delete(ProductDetail val)
        {
            ProductDetailDeleteDAL instance = new ProductDetailDeleteDAL();
            instance.Delete(val);
        }

         public void Add(ProductDetail val)
        {

            ProductDetailInsertDAL instance = new ProductDetailInsertDAL();
            instance.Add(val);
           
        }
    }
}
