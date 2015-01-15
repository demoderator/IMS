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

            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewProduct_Detail.ToString();
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
                                            new SqlParameter("@p_QuantityUnit", ProductDetail.Quantity), 
                                            new SqlParameter("@p_Discount", ProductDetail.Discount), 
                                            new SqlParameter("@p_SalePrice", ProductDetail.SalePrice), 
                                            new SqlParameter("@p_DateExpired", ProductDetail.DateExpired), 
                                            new SqlParameter("@p_ProductID ", ProductDetail.ProductMasterID), 
                                            new SqlParameter("@p_CostPrice", ProductDetail.CostPrice), 

                                            new SqlParameter("@p_Status", ProductDetail.Status), 
                                            new SqlParameter("@p_DateCreated ", ProductDetail.DateCreated), 
                                            new SqlParameter("@p_DateUpdated", ProductDetail.DateUpdated) 
                                        
                                        
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
