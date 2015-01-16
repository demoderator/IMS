using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class StockDetailSearchDAL : DataAccessbase
    {
        StockDetailSearchDALDataParameter _insertParameters;
        public StockDetailSearchDAL()
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetStockDetailByParameters.ToString();

        }

        public DataSet View(StockDetails val)
        {

            DataSet ds;
            _insertParameters = new StockDetailSearchDALDataParameter(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, _insertParameters.Parameters);
            return ds;
        }


    }


    public class StockDetailSearchDALDataParameter
    {
        private StockDetails _pDetail;
        private SqlParameter[] _parameters;

        public StockDetailSearchDALDataParameter(StockDetails val)
        {
            PDetail = val;
            Build();
        }
        public void Build()
        {

            string GetID = null;
            if (PDetail.UserRoleID != 0)
            {
                GetID = Convert.ToString(PDetail.UserRoleID);
            }


            SqlParameter[] parameters = { new SqlParameter("@p_UserRoleID",GetID),
                                            new SqlParameter("@p_ProductID", PDetail.ProductID)
                                        
                                        
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

