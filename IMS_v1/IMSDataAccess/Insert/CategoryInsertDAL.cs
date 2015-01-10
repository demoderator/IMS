using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class CategoryInsertDAL:DataAccessbase
    {
        CategoryInsertDataParameters  _insertParameters;

        public CategoryInsertDAL() 
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewCategory.ToString();
        }

        public void Add(Category category)
        {

            _insertParameters = new CategoryInsertDataParameters(category);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class CategoryInsertDataParameters
    {
        private Category _category;
        private SqlParameter[] _parameters;

        public CategoryInsertDataParameters(Category category)
        {
            CategoryInstance = category;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Name", CategoryInstance.Name), new SqlParameter("@p_DepartmentID", CategoryInstance.DepartmentID) };
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
