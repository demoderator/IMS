using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class SubCategoryInsertDAL:DataAccessbase
    {
        SubCategoryInsertDataParameters  _insertParameters;

        public SubCategoryInsertDAL() 
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewSubCategory.ToString();
        }

        public void Add(SubCategory subCategory)
        {

            _insertParameters = new SubCategoryInsertDataParameters(subCategory);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class SubCategoryInsertDataParameters
    {
        private SubCategory _subCategory;
        private SqlParameter[] _parameters;

        public SubCategoryInsertDataParameters(SubCategory subCat)
        {
            SubCategory = subCat;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Name", SubCategory.Name), new SqlParameter("@p_CategoryId", SubCategory.CategoryID) };
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
