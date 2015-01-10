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
            Sp_AddNewDepartment,
            Sp_AddNewSubCategory,
            Sp_AddNewCategory
        }
        public enum Select 
        {
            Sp_GetDepartmentList,
            Sp_GetSubCategoryList,
            Sp_GetCategoryList,
            Sp_GetProductList
        }
        public enum Delete 
        {
            Sp_DeleteDepartment,
            Sp_DeleteSubCategory,
            Sp_DeleteCategory
        }
        public enum Update 
        {
            Sp_UpdateSelectedDepartment,
            Sp_UpdateSubCategory,
            Sp_UpdateCategory
        }
    }
}
