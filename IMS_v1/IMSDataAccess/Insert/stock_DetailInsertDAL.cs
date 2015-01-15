using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Insert
{
    public class stock_DetailInsertDAL : DataAccessbase
    {
        stock_DetailInsertDALDataParameters _insertParameters;
        public stock_DetailInsertDAL()
        {
            StoredProcedureName = StoredProcedure.Insert.Sp_AddNewStock.ToString();
        }

        public void Add(StockDetails stockDetails)
        {

            _insertParameters = new stock_DetailInsertDALDataParameters(stockDetails);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }



    public class stock_DetailInsertDALDataParameters
    {
        private StockDetails _stockDetails;


        public stock_DetailInsertDALDataParameters(StockDetails stockdetails)
        {
            stockdetails = _stockDetails;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_ProductID", StockDetails.ProductID) };
            Parameters = parameters;
        }
        public StockDetails StockDetails
        {
            get { return _stockDetails; }
            set { _stockDetails = value; }
        }
        private SqlParameter[] _parameters;

        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

    }
}
