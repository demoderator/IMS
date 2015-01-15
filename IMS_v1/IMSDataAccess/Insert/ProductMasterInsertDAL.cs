using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class ProductMasterInsertDAL : DataAccessbase
    {
        ProductMasterInsertDataParameters _insertParameters;
        public ProductMasterInsertDAL()
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewProductMaster.ToString();
        }

        public void Add(ProductMaster pro)
        {

            _insertParameters = new ProductMasterInsertDataParameters(pro);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }


    public class ProductMasterInsertDataParameters
    {
        private ProductMaster _ProductMaster;
        private SqlParameter[] _parameters;

        public ProductMasterInsertDataParameters(ProductMaster pro)
        {
            ProductMaster = pro;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@p_ProductName", ProductMaster.ProductName), 
                                            new SqlParameter("@p_Description", ProductMaster.ProductDescription), 
                                            new SqlParameter("@p_Status", ProductMaster.Status), 
                                             new SqlParameter("@p_Manufacturer", ProductMaster.Manufacturer), 
                                             new SqlParameter("@p_Pack", ProductMaster.Pack), 
                                             new SqlParameter("@p_UnitSize", ProductMaster.UnitSize), 
                                             new SqlParameter("@p_WUnit", ProductMaster.WUnit), 
                                             new SqlParameter("@p_ProductType", ProductMaster.ProductType), 
                                             new SqlParameter("@p_ProductSelection", ProductMaster.ProductSelection), 
                                             new SqlParameter("@p_SubCategoryID", ProductMaster.SubCategoryID), 
                                             new SqlParameter("@p_LastOrderDate", ProductMaster.LastOrderDate), 
                                             new SqlParameter("@p_DateCreated", ProductMaster.DateCreated), 
                                             new SqlParameter("@p_UPC", ProductMaster.Upc), 
                                                  new SqlParameter("@p_ProductCode", ProductMaster.ProductCode), 
                                            new SqlParameter("@p_ThreshHold", ProductMaster.ThreshHold), 
                                            new SqlParameter("@p_lastUpdatedDate", ProductMaster.LastOrderDate)
                                        
                                        
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
        public ProductMaster ProductMaster
        {
            get
            {
                return _ProductMaster;
            }
            set
            {
                _ProductMaster = value;
            }
        }
    }
}
