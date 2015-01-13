using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class ProductMasterDeleteDAL:DataAccessbase
    {
         ProductMasterDeleteDataParameters _insertParameters;
         public ProductMasterDeleteDAL() 
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteProductMasterById.ToString();
        }

         public void Delete(ProductMaster val)
        {

            _insertParameters = new ProductMasterDeleteDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class ProductMasterDeleteDataParameters
    {
        private ProductMaster _pMaster;
        private SqlParameter[] _parameters;

        public ProductMasterDeleteDataParameters(ProductMaster val)
        {
            PMaster = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", PMaster.ProductID) };
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
