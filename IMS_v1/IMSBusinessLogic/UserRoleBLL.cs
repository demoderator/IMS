using IMSCommon;
using IMSDataAccess.Delete;
using IMSDataAccess.Insert;
using IMSDataAccess.Select;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSBusinessLogic
{
    public class UserRoleBLL
    {
        public UserRoleBLL() { }

        public static DataSet GetAllUserRoles()
        {
            DataSet resultSet = new DataSet();
            UserRoleSelectDAL instance = new UserRoleSelectDAL();
            resultSet = instance.View();
            return resultSet;
        }

        public DataSet GetUserRoleById(UserRoles val) 
        {
            DataSet resultSet = new DataSet();
            UserRoleSelectByIdDAL instance = new UserRoleSelectByIdDAL();
            resultSet = instance.View(val);
            return resultSet;
        }

        public void Add(UserRoles val) 
        {
            UserRoleInsertDAL instance = new UserRoleInsertDAL();
            instance.Add(val);
        }

        public void Delete(UserRoles val)
        {
            UserRoleDeleteDAL instance = new UserRoleDeleteDAL();
            instance.Delete(val);
        }

        public void Update(SystemRoles val)
        {
            
        }
    }
}
