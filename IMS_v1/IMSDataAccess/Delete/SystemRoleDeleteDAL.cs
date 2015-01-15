using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class SystemRoleDeleteDAL:DataAccessbase
    {
        SystemRoleDeleteDataParameters _insertParameters;

        public SystemRoleDeleteDAL() 
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteSystem_RoleById.ToString();
        }
        public void Delete(SystemRoles val)
        {
            _insertParameters = new SystemRoleDeleteDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    internal class SystemRoleDeleteDataParameters
    {
        private SystemRoles _systemRole;
        private SqlParameter[] _parameters;

        public SystemRoleDeleteDataParameters(SystemRoles val)
        {
            SystemRoles = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_RoleID", SystemRoles.RoleID) };
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
