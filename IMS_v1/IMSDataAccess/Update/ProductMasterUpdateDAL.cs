using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class ProductMasterUpdateDAL:DataAccessbase
    {
        ProductMasterUpdateDataParameters _insertParameters;
        public ProductMasterUpdateDAL() 
        {
            StoredProcedureName = StoredProcedure.Update.Sp_UpdateProductMasterById.ToString();
        }

        public void Update(ProductMaster val)
        {

            _insertParameters = new ProductMasterUpdateDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }

    public class ProductMasterUpdateDataParameters
    {
        private ProductMaster _pMaster;
        private SqlParameter[] _parameters;

        public ProductMasterUpdateDataParameters(ProductMaster val)
        {
            PMaster = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", PMaster.ProductID)};
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
