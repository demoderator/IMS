using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class DepartmentDeleteDAL:DataAccessbase
    {
        DepartmentDeleteDataParameters _insertParameters;
        public DepartmentDeleteDAL() 
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteDepartment.ToString();
        }

        public void Delete(Department dep)
        {

            _insertParameters = new DepartmentDeleteDataParameters(dep);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class DepartmentDeleteDataParameters
    {
        private Department _department;
        private SqlParameter[] _parameters;

        public DepartmentDeleteDataParameters(Department dep)
        {
            Department = dep;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id",Department.DepartmentID) };
            Parameters = parameters;
        }
        public SqlParameter[] Parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        public Department Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }
    }
    
}
