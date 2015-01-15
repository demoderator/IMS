using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class SystemRoleInsertDAL:DataAccessbase
    {
        SystemRoleInsertDataParameters _insertParameters;

         public SystemRoleInsertDAL() 
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewSystemRole.ToString();
        }

         public void Add(SystemRoles dep)
        {

            _insertParameters = new SystemRoleInsertDataParameters(dep);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    internal class SystemRoleInsertDataParameters
    {
        private SystemRoles _systemRole;
        private SqlParameter[] _parameters;

        public SystemRoleInsertDataParameters(SystemRoles dep)
        {
            SystemRoles = dep;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Name", SystemRoles.RoleName) };
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
        public SystemRoles SystemRoles
        {
            get
            {
                return _systemRole;
            }
            set
            {
                _systemRole = value;
            }
        }
    }
}
