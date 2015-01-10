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
    public class CategoryBLL
    {
          public CategoryBLL() { }

        public static DataSet GetAllCategories()
        {
            
            DataSet resultSet = new DataSet();

            CategorySelectDAL categoryInstance = new CategorySelectDAL();
            resultSet = categoryInstance.View();
        
            return resultSet;
        }

        public void Update(Category category)
        {
            CategoryUpdateDAL categoryUpdateDAL = new CategoryUpdateDAL();
            categoryUpdateDAL.Update(category);
        }

        public void Delete(Category category)
        {
            CategoryDeleteDAL categoryDeleteDAL = new CategoryDeleteDAL();
            categoryDeleteDAL.Delete(category);
        }

        public void Add(Category category)
        {
            CategoryInsertDAL categoryInsertDAL = new CategoryInsertDAL();
            categoryInsertDAL.Add(category);
        }
    }
}
