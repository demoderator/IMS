using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class CategoryDeleteDAL:DataAccessbase
    {
         CategoryDeleteDataParameters _insertParameters;
        public CategoryDeleteDAL() 
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteCategory.ToString();
        }

        public void Delete(Category category)
        {
            _insertParameters = new CategoryDeleteDataParameters(category);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class CategoryDeleteDataParameters
    {
        private Category _category;
        private SqlParameter[] _parameters;

        public CategoryDeleteDataParameters(Category category)
        {
            CategoryInstance = category;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", CategoryInstance.CategoryID) };
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
        public Category CategoryInstance
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
    }
}
