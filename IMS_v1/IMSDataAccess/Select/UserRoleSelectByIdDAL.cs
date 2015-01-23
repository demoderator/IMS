using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class UserRoleSelectByIdDAL: DataAccessbase
    {
        UserRoleSelectDataParameters _insertParameters;
        public UserRoleSelectByIdDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetUser_RolesById.ToString();
        }

        public DataSet View(UserRoles val)
        {

            DataSet ds;
            _insertParameters = new UserRoleSelectDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString,_insertParameters.Parameters);
            return ds;
        }

    }

    internal class UserRoleSelectDataParameters
    {
        private UserRoles _userRole;
        private SqlParameter[] _parameters;

        public UserRoleSelectDataParameters(UserRoles val)
        {
            UserRoles = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_userRoleID", UserRoles.UserRoleId) };
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
        public UserRoles UserRoles
        {
            get
            {
                return _userRole;
            }
            set
            {
                _userRole = value;
            }
        }
    }
}
