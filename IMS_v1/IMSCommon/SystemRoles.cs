using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSCommon
{
    public class SystemRoles
    {
        #region fields
        string roleName;
        int roleID; 
        #endregion

        public SystemRoles() { }

        #region properties

        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }


        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        } 
        #endregion
    }
}
