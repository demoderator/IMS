using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class ProductDetailUpdateDAL : DataAccessbase
    {
        ProductDetailUpdateDataParameters _insertParameters;
        public ProductDetailUpdateDAL()
        {
            StoredProcedureName = StoredProcedure.Update.Sp_UpdateProduct_DetailById.ToString();
        }

        public void Update(ProductDetail val)
        {

            _insertParameters = new ProductDetailUpdateDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class ProductDetailUpdateDataParameters
    {
        private ProductDetail _pMaster;
        private SqlParameter[] _parameters;

        public ProductDetailUpdateDataParameters(ProductDetail val)
        {
            PDetails = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_ProductDetail_ID ", PDetails.ProductDetailID),
                                            new SqlParameter("@p_ExpDate", PDetails.DateExpired), 
                                            new SqlParameter("@p_SalePrice", PDetails.SalePrice), 
                                            new SqlParameter("@p_CostPrice", PDetails.CostPrice), 
                                        };

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
        public ProductDetail PDetails
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
