using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class ProductMasterUpdateDAL : DataAccessbase
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
            ProductMaster = val;
            Build();
        }

        public void Build()
        {
            SqlParameter[] parameters = {   
                                            new SqlParameter("@p_ProductID", ProductMaster.ProductID),
                                            new SqlParameter("@p_ProductName", ProductMaster.ProductName), 
                                            new SqlParameter("@p_Description", ProductMaster.ProductDescription), 
                                            new SqlParameter("@p_Status", ProductMaster.Status), 
                                            new SqlParameter("@p_Meas_Qty",ProductMaster.MeasureQuantity),
                                            new SqlParameter("@p_Meas_type",ProductMaster.MeasureType),
                                            new SqlParameter("@p_Qty_Unit", ProductMaster.QuanityUnit), 
                                            new SqlParameter("@p_Manufacturer", ProductMaster.Manufacturer), 
                                    
                                            new SqlParameter("@p_Control",ProductMaster.Control),
                                            new SqlParameter("@p_Bin_Number",ProductMaster.BinNumber),
                                            new SqlParameter("@p_MaxiMumDiscount", ProductMaster.MaxDiscount), 
                                            new SqlParameter("@p_LineID", ProductMaster.LineID), 
                                            new SqlParameter("@p_Expiry", ProductMaster.Expiry), 
                                            new SqlParameter("@p_GName", ProductMaster.GenericName), 
                                            new SqlParameter("@p_SP", ProductMaster.SalePrice), 
                                            new SqlParameter("@p_UnitCost", ProductMaster.CostPrice), 
                                           
                                            new SqlParameter("@p_ProductType", ProductMaster.ProductType), 
                                            new SqlParameter("@p_ProductSelection", ProductMaster.ProductSelection), 
                                            new SqlParameter("@p_SubCategoryID", ProductMaster.SubCategoryID), 
                                            new SqlParameter("@p_ProductCode", ProductMaster.ProductCode), 
                                            new SqlParameter("@p_ThreshHold", ProductMaster.ThreshHold) 
                                          
               
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
                return _pMaster;
            }
            set
            {
                _pMaster = value;
            }
        }
    }
}
