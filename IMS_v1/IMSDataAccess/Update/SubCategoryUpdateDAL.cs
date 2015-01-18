using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class SubCategoryUpdateDAL:DataAccessbase
    {
        
        SubCategoryUpdateDataParameters _insertParameters;
        public SubCategoryUpdateDAL() 
        {
            StoredProcedureName = StoredProcedure.Update.Sp_UpdateSelectedSubCategory.ToString();
        }

        public void Update(SubCategory subCategory)
        {

            _insertParameters = new SubCategoryUpdateDataParameters(subCategory);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class SubCategoryUpdateDataParameters
    {
         private SubCategory _subCategory;
        private SqlParameter[] _parameters;

        public SubCategoryUpdateDataParameters(SubCategory subCat)
        {
            SubCategory = subCat;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", SubCategory.SubCategoryID), new SqlParameter("@p_Name", SubCategory.Name), new SqlParameter("@p_CategoryName", SubCategory.CategoryName)
                                         ,new SqlParameter("@p_DepartmentName",SubCategory.DepartmentName) };
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
        public SubCategory SubCategory
        {
            get
            {
                return _subCategory;
            }
            set
            {
                _subCategory = value;
            }
        }
    }
}
