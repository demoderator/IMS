using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class DepartmentUpdateDAL:DataAccessbase
    {
        DepartmentUpdateDataParameters _insertParameters;
        public DepartmentUpdateDAL() 
        {
            StoredProcedureName = StoredProcedure.Update.Sp_UpdateSelectedDepartment.ToString();
        }

        public void Update(Department dep)
        {

            _insertParameters = new DepartmentUpdateDataParameters(dep);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class DepartmentUpdateDataParameters
    {
        private Department _department;
        private SqlParameter[] _parameters;

        public DepartmentUpdateDataParameters(Department dep)
        {
            Department = dep;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id",Department.DepartmentID),new SqlParameter("@p_Name", Department.Name), new SqlParameter("@p_Code", Department.Code) };
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
