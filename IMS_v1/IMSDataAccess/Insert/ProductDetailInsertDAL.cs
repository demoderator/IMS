using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class ProductDetailInsertDAL : DataAccessbase
    {

        ProductDetailInsertDataParameters _insertParameters;

        public ProductDetailInsertDAL()
        {

            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewProductMaster.ToString();
        }

        public void Add(ProductDetail proDe)
        {

            _insertParameters = new ProductDetailInsertDataParameters(proDe);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }


    public class ProductDetailInsertDataParameters
    {
        private ProductDetail _ProductDetail;
        private SqlParameter[] _parameters;

        public ProductDetailInsertDataParameters(ProductDetail proDe)
        {
            ProductDetail = proDe;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@Name", ProductDetail.DateCreated), 
                                            new SqlParameter("@Code", ProductDetail.DateCreated) 
                                        
                                        
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
        public ProductDetail ProductDetail
        {
            get
            {
                return _ProductDetail;
            }
            set
            {
                _ProductDetail = value;
            }
        }
    }
}
