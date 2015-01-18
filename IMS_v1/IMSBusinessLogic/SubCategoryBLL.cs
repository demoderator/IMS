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
    public class SubCategoryBLL
    {
        public SubCategoryBLL() { }

        public static DataSet GetAllSubCategories()
        {
            
            DataSet resultSet = new DataSet();

            SubCategorySelectDAL subCatInstance = new SubCategorySelectDAL();
            resultSet = subCatInstance.View();
        
            return resultSet;
        }

        public DataSet GetById(SubCategory val)
        {
            DataSet resultSet = new DataSet();

            IMSDataAccess.Select.SubCategorySelectByIdDAL depInstance = new IMSDataAccess.Select.SubCategorySelectByIdDAL();
            resultSet = depInstance.View(val);
            return resultSet;
        }

        public void Update(SubCategory subCategory)
        {
            SubCategoryUpdateDAL subCatUpdateDAL= new SubCategoryUpdateDAL();
            subCatUpdateDAL.Update(subCategory);
        }

        public void Delete(SubCategory subCategory)
        {
            SubCategoryDeleteDAL subCategoryDeleteDAL = new SubCategoryDeleteDAL();
            subCategoryDeleteDAL.Delete(subCategory);
        }

        public void Add(SubCategory subCategory)
        {
            SubCategoryInsertDAL subCategoryInsertDAL = new SubCategoryInsertDAL();
            subCategoryInsertDAL.Add(subCategory);
        }
    }
}
