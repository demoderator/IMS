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
    public class SystemRoleBLL
    {
        public SystemRoleBLL() { }

        public static DataSet GetAllSystemRoles()
        {
            DataSet resultSet = new DataSet();
            SystemRoleSelectDAL instance = new SystemRoleSelectDAL();
            resultSet = instance.View();
            return resultSet;
        }

        public DataSet GetSystemRoleById(SystemRoles val) 
        {
            DataSet resultSet = new DataSet();
            SystemRoleSelectByIdDAL instance = new SystemRoleSelectByIdDAL();
            resultSet = instance.View(val);
            return resultSet;
        }

        public void Add(SystemRoles val) 
        {
            SystemRoleInsertDAL instance = new SystemRoleInsertDAL();
            instance.Add(val);
        }

        public void Delete(SystemRoles val)
        {
            SystemRoleDeleteDAL instance = new SystemRoleDeleteDAL();
            instance.Delete(val);
        }

        public void Update(SystemRoles val)
        {
            
        }
    }
}
