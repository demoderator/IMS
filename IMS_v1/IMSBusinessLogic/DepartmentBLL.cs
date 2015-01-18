using IMSCommon;
using IMSDataAccess.Delete;
using IMSDataAccess.Insert;
using IMSDataAccess.Update;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSBusinessLogic
{
    public class DepartmentBLL
    {
        public DepartmentBLL() { }
       // public static List<Department> GetAllDepartment()
        public static DataSet GetAllDepartment()
        {
            List<Department> depList = new List<Department>();
            DataSet resultSet = new DataSet();
            
            IMSDataAccess.Select.DepartmentSelectDAL depInstance = new IMSDataAccess.Select.DepartmentSelectDAL();
            resultSet = depInstance.View();
            #region commented code for list<department>
            //if (resultSet.Tables.Count == 1) 
            //{
            //    DataRow[] rows = resultSet.Tables[0].Select();
            //    foreach (DataRow temp in rows) 
            //    {
            //        Department dep = new Department();

            //        if (temp.ItemArray[0] !=null)
            //        dep.DepartmentID=(int)temp.ItemArray[0];

            //        if (temp.ItemArray[1] != null)
            //            dep.Name = (string)temp.ItemArray[1];

            //        if (temp.ItemArray[2] != DBNull.Value)
            //            dep.Code=(string)temp.ItemArray[2];

            //        depList.Add(dep);
            //    }

            //}

            //return depList; 
            #endregion
            return resultSet;
        }

        public DataSet GetById(Department val) 
        {
            DataSet resultSet = new DataSet();

            IMSDataAccess.Select.DepartmentSelectByIdDAL depInstance = new IMSDataAccess.Select.DepartmentSelectByIdDAL();
            resultSet = depInstance.View(val);
            return resultSet;
        }

        public void Update(Department dep) 
        {
            DepartmentUpdateDAL depUpdateDAL = new DepartmentUpdateDAL();
            depUpdateDAL.Update(dep);
        }

        public void Delete(Department dep)
        {
            DepartmentDeleteDAL depDeleteDAL = new DepartmentDeleteDAL();
            depDeleteDAL.Delete(dep);
        }

        public void Add(Department dep) 
        {
            DepartmentInsertDAL depInsertDAL = new DepartmentInsertDAL();
            depInsertDAL.Add(dep);
        }
    }
}
