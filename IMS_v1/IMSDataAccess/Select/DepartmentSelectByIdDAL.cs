using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class DepartmentSelectByIdDAL:DataAccessbase
    {
         DepartmentSelectDataParameters _insertParameters;

        public DepartmentSelectByIdDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetDepartmentById.ToString();
        }

        public DataSet View(Department dep)
        {
            DataSet ds;
            _insertParameters = new DepartmentSelectDataParameters(dep);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds=dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
            return ds;
        }
    }
    public class DepartmentSelectDataParameters
    {
        private Department _department;
        private SqlParameter[] _parameters;

        public DepartmentSelectDataParameters(Department dep)
        {
            Department = dep;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", Department.DepartmentID) };
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
