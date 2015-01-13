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
            Sp_AddNewCategory,
            Sp_AddNewProductMaster
        }
        public enum Select 
        {
            Sp_GetDepartmentList,
            Sp_GetSubCategoryList,
            Sp_GetCategoryList,
            Sp_GetProductList,
            Sp_GetProductMaster,
            Sp_GetProductMasterById
        }
        public enum Delete 
        {
            Sp_DeleteDepartment,
            Sp_DeleteSubCategory,
            Sp_DeleteCategory,
            Sp_DeleteProductMasterById
        }
        public enum Update 
        {
            Sp_UpdateSelectedDepartment,
            Sp_UpdateSubCategory,
            Sp_UpdateCategory,
            Sp_UpdateProductMasterById
        }
    }
}
