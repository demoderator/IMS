using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class StockExpiryDetailsDal:DataAccessbase
    {
        StockExpiryDetailsDalDataParameters _insertParameters;
        public StockExpiryDetailsDal()
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetProductExpiryDetails.ToString();
        }

        public DataSet View(StockDetails val)
        {

            DataSet ds;
            _insertParameters = new StockExpiryDetailsDalDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, _insertParameters.Parameters);
            return ds;
        }
    }


    public class StockExpiryDetailsDalDataParameters
    {


        private StockDetails _pDetail;
        private SqlParameter[] _parameters;

        public StockExpiryDetailsDalDataParameters(StockDetails val)
        {
            PDetail = val;
            Build();
        }
        public void Build()
        {

            string GetID = null;
            string prodId = null;
            if (PDetail.UserRoleID != 0)
            {
                GetID = Convert.ToString(PDetail.UserRoleID);
            }

            if (PDetail.ProductID != 0)
            {
                prodId = Convert.ToString(PDetail.ProductID);
            }

            SqlParameter[] parameters = { new SqlParameter("@p_UserRoleID",GetID),
                                            new SqlParameter("@p_ProductID", prodId)
                                        
                                        
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
        public StockDetails PDetail
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
