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

        public static DataSet GetAllDepartment()
        {
          
            DataSet resultSet = new DataSet();

            IMSDataAccess.Select.ProductSelectDAL prodInstance = new IMSDataAccess.Select.ProductSelectDAL();
            resultSet = prodInstance.View();
           
            return resultSet;
        }
    }
}
