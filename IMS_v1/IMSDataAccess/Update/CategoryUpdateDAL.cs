using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class CategoryUpdateDAL:DataAccessbase
    {
        CategoryUpdateDataParameters _insertParameters;
        public CategoryUpdateDAL() 
        {
            StoredProcedureName = StoredProcedure.Update.Sp_UpdateSelectedCategory.ToString();
        }

        public void Update(Category _category)
        {

            _insertParameters = new CategoryUpdateDataParameters(_category);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class CategoryUpdateDataParameters
    {
        private Category _category;
        private SqlParameter[] _parameters;

        public CategoryUpdateDataParameters(Category _cat)
        {
            CategoryInstance = _cat;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", CategoryInstance.CategoryID), new SqlParameter("@p_Name", CategoryInstance.Name), new SqlParameter("@p_DepartmentId", CategoryInstance.DepartmentID) };
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
