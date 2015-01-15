using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class ProductDetailSelectByDetailIdDAL : DataAccessbase
    {
        ProductDetailSelectByDetailIDDataParameters _insertParameters;
        public ProductDetailSelectByDetailIdDAL()
        {


            StoredProcedureName = StoredProcedure.Select.Sp_GetPro_DetailByDId.ToString();
}

        public DataSet View(ProductDetail val)
        {
            DataSet ds;
            _insertParameters = new ProductDetailSelectByDetailIDDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, _insertParameters.Parameters);
            return ds;
        }

    }
    public class ProductDetailSelectByDetailIDDataParameters
    {
        private ProductDetail _pDetail;
        private SqlParameter[] _parameters;

        public ProductDetailSelectByDetailIDDataParameters(ProductDetail val)
        {
            PDetail = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_ProductDetail_ID", PDetail.ProductDetailID)
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
