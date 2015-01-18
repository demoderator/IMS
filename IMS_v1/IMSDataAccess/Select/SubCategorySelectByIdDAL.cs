using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class SubCategorySelectByIdDAL:DataAccessbase
    {
        SubCategorySelectDataParameters  _insertParameters;

        public SubCategorySelectByIdDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetSubCategoryById.ToString();
        }

        public DataSet View(SubCategory subCategory)
        {
            DataSet ds;
            _insertParameters = new SubCategorySelectDataParameters(subCategory);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds=dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
            return ds;
        }
    }

    public class SubCategorySelectDataParameters
    {
        private SubCategory _subCategory;
        private SqlParameter[] _parameters;

        public SubCategorySelectDataParameters(SubCategory subCat)
        {
            SubCategory = subCat;
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
