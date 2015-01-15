using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class SystemRoleSelectByIdDAL:DataAccessbase
    {
        SystemRoleSelectDataParameters _insertParameters;
        public SystemRoleSelectByIdDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetSystem_RoleById.ToString();
        }

        public DataSet View(SystemRoles val)
        {
            DataSet ds;

            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            _insertParameters = new SystemRoleSelectDataParameters(val);
            ds = dbHelper.Run(ConnectionString,_insertParameters.Parameters);
            return ds;
        }
    }

    internal class SystemRoleSelectDataParameters
    {
        private SystemRoles _systemRole;
        private SqlParameter[] _parameters;

        public SystemRoleSelectDataParameters(SystemRoles val)
        {
            SystemRoles = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@Name", SystemRoles.RoleID) };
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
