using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class stockDetailsByIdDAL : DataAccessbase
    {
        stockDetailsByIdDALDataparameters _insertParameters;
        public stockDetailsByIdDAL()
        {

        }

        public DataSet View(StockDetails val)
        {

            DataSet ds;
            _insertParameters = new stockDetailsByIdDALDataparameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, _insertParameters.Parameters);
            return ds;
        }

    }


    public class stockDetailsByIdDALDataparameters
    {


        private StockDetails _stockDetails;


        public stockDetailsByIdDALDataparameters(StockDetails stockdetails)
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

