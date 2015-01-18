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

        public DataSet GetById(Category val)
        {
            DataSet resultSet = new DataSet();

            IMSDataAccess.Select.CategorySelectByIdDAL depInstance = new IMSDataAccess.Select.CategorySelectByIdDAL();
            resultSet = depInstance.View(val);
            return resultSet;
        }

        public static DataSet GetDistinct() 
        {
            DataSet resultSet = new DataSet();

            IMSDataAccess.Select.CategoryDistinctSelectDAL depInstance = new IMSDataAccess.Select.CategoryDistinctSelectDAL();
            resultSet = depInstance.View();
            return resultSet;
        }
        public DataSet GetDepListByCategoryName(Category val)
        {
            DataSet resultSet = new DataSet();

            IMSDataAccess.Select.DepartmentSelectByCategoryNameDAL depInstance = new IMSDataAccess.Select.DepartmentSelectByCategoryNameDAL();
            resultSet = depInstance.View(val);
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
