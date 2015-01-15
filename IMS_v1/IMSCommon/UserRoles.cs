using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSCommon
{
    public class UserRoles
    {
        #region fields
        int userRoleId;
        int systemRoleId;
        string userRoleName;
        string description; 
        #endregion

        public UserRoles() { }

        #region properties
        public int UserRoleId
        {
            get { return userRoleId; }
            set { userRoleId = value; }
        }

        public int SystemRoleId
        {
            get { return systemRoleId; }
            set { systemRoleId = value; }
        }

        public string UserRoleName
        {
            get { return userRoleName; }
            set { userRoleName = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        } 
        #endregion


    }
}
