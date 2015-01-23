using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class DepartmentInsertDAL:DataAccessbase
    {
        DepartmentInsertDataParameters _insertParameters;

        public DepartmentInsertDAL() 
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_PalceeNewOrder.ToString();
        }

        public void Add(Department dep)
        {

            _insertParameters = new DepartmentInsertDataParameters(dep);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class DepartmentInsertDataParameters
    {
        private Department _department;
        private SqlParameter[] _parameters;

        public DepartmentInsertDataParameters(Department dep)
        {
            Department = dep;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@Name", Department.Name) , new SqlParameter("@Code",Department.Code)};
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
