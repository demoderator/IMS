using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class ProductDetailDeleteDAL:DataAccessbase
    {
          ProductDetailDeleteDataParameters _insertParameters;
          public ProductDetailDeleteDAL() 
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteProduct_DetailById.ToString();
        }

          public void Delete(ProductDetail val)
        {

            _insertParameters = new ProductDetailDeleteDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }

    public class ProductDetailDeleteDataParameters
    {
        private ProductDetail _pDetail;
        private SqlParameter[] _parameters;

        public ProductDetailDeleteDataParameters(ProductDetail val)
        {
            PDetail = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_ProductDetail_ID", PDetail.ProductDetailID) };
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
        public ProductDetail PDetail
        {
            get
            {
                return _pDetail;
            }
            set
            {
                _pDetail = value;
            }
        }
    }
}
