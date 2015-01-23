using IMSDataAccess.Select;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSBusinessLogic
{
    public class ProductBLL
    {
        public ProductBLL() { }

        public static DataSet GetAllProducts()
        {
          
            DataSet resultSet = new DataSet();

            IMSDataAccess.Select.ProductSelectDAL prodInstance = new IMSDataAccess.Select.ProductSelectDAL();
            resultSet = prodInstance.View();
           
            return resultSet;
        }


        public static DataSet GetAvailableProducts()
        {

            DataSet resultSet = new DataSet();

            GetAvailableProductDAL prodInstance = new GetAvailableProductDAL();
            resultSet = prodInstance.View();

            return resultSet;
        }

    }
}
