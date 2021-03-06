﻿using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class UserRoleDeleteDAL:DataAccessbase
    {
        UserRoleDeleteDataParameters _insertParameters;
        public UserRoleDeleteDAL() 
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteUser_RoleById.ToString();
        }

        public void Delete(UserRoles val)
        {
            _insertParameters = new UserRoleDeleteDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    internal class UserRoleDeleteDataParameters
    {
        private UserRoles _userRole;
        private SqlParameter[] _parameters;

        public UserRoleDeleteDataParameters(UserRoles dep)
        {
            UserRoles = dep;
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
