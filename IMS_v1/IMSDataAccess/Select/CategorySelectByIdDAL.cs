using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class CategorySelectByIdDAL:DataAccessbase
    {
        CategorySelectDataParameters  _insertParameters;

        public CategorySelectByIdDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetCategoryById.ToString();
        }

        public DataSet View(Category category)
        {
            DataSet ds; 
            _insertParameters = new CategorySelectDataParameters(category);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds=dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
            return ds;
        }
    }

    public class CategorySelectDataParameters
    {
        private Category _category;
        private SqlParameter[] _parameters;

        public CategorySelectDataParameters(Category category)
        {
            CategoryInstance = category;
            Build();
        }

        public CategorySelectDataParameters(Category category, bool byName) 
        {
            CategoryInstance = category;
            BuildByName();
            

        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_id", CategoryInstance.CategoryID) };
            
            Parameters = parameters;
        }

        public void BuildByName()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Name", CategoryInstance.Name) };

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
