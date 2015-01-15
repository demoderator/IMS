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
                                            new SqlParameter("@Name", ProductMaster.ProductCode), 
                                            new SqlParameter("@Code", ProductMaster.ProductCode) 
                                        
                                        
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
