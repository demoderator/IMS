using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public  class ProductDetailSelectByIdDAL:DataAccessbase
    {
        ProductDetailSelectByIDDataParameters _insertParameters;
        public ProductDetailSelectByIdDAL() 
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetProduct_DetailById.ToString();
        }

        public DataSet View(ProductDetail val)
        {
            DataSet ds;
            _insertParameters = new ProductDetailSelectByIDDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString,_insertParameters.Parameters);
            return ds;
        }
    }

    public class ProductDetailSelectByIDDataParameters
    {
        private ProductDetail _pDetail;
        private SqlParameter[] _parameters;

        public ProductDetailSelectByIDDataParameters(ProductDetail val)
        {
            PDetail = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Id", PDetail.ProductDetailID) };
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
