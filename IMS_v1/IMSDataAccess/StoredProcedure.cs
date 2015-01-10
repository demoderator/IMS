using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSDataAccess
{
    public class StoredProcedure
    {
        public enum Insert 
        {
            Sp_AddNewDepartment
        }
        public enum Select 
        {
            Sp_GetDepartmentList
        }
        public enum Delete 
        {
            Sp_DeleteDepartment
        }
        public enum Update 
        {
            Sp_UpdateSelectedDepartment
        }
    }
}
