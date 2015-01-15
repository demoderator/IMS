using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class ProductMasterSelectByIdDAL:DataAccessbase
    {
        ProductMasterSelectByIDDataParameters _insertParameters;
        public ProductMasterSelectByIdDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetProductMasterById.ToString();
        }

        public DataSet View(ProductMaster val)
        {
            DataSet ds;
            _insertParameters = new ProductMasterSelectByIDDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString,_insertParameters.Parameters);
            return ds;
        }

    }

    public class ProductMasterSelectByIDDataParameters
    {
        private ProductMaster _pMaster;
        private SqlParameter[] _parameters;

        public ProductMasterSelectByIDDataParameters(ProductMaster val)
        {
            PMaster = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_ProductID", PMaster.ProductID) };
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
        public ProductMaster PMaster
        {
            get
            {
                return _pMaster;
            }
            set
            {
                _pMaster = value;
            }
        }
    }
}
