using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class UserRoleInsertDAL:DataAccessbase
    {
        UserRoleInsertDataParameters _insertParameters;
        public UserRoleInsertDAL() 
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewUser_Role.ToString();
        }

        public void Add(UserRoles dep)
        {

            _insertParameters = new UserRoleInsertDataParameters(dep);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    internal class UserRoleInsertDataParameters
    {
        private UserRoles _userRole;
        private SqlParameter[] _parameters;

        public UserRoleInsertDataParameters(UserRoles dep)
        {
            UserRoles = dep;
            Build();
        }
        public void Build()
        {
   
            SqlParameter[] parameters = { new SqlParameter("@p_Name", UserRoles.UserRoleName), new SqlParameter("@p_Description", UserRoles.Description)
            ,new SqlParameter("@p_roleID ", UserRoles.SystemRoleId) };
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
