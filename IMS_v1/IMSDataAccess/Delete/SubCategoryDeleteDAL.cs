using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class SubCategoryDeleteDAL:DataAccessbase
    {
       SubCategoryDeleteDataParameters _insertParameters;
        public SubCategoryDeleteDAL() 
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteSubCategory.ToString();
        }

        public void Delete(SubCategory subCategory)
        {
            _insertParameters = new SubCategoryDeleteDataParameters(subCategory);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }
    public class SubCategoryDeleteDataParameters
    {
        private SubCategory _subCategory;
        private SqlParameter[] _parameters;

        public SubCategoryDeleteDataParameters(SubCategory subCategory)
        {
            SubCategory = subCategory;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", SubCategory.SubCategoryID) };
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
