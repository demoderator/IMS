using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class stockDetailsUpdateDAL : DataAccessbase
    {
        stockDetailsUpdateDALDataParameters _insertParameters;
        public stockDetailsUpdateDAL()
        {

        }

        public void Update(StockDetails val)
        {

            _insertParameters = new stockDetailsUpdateDALDataParameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }
    }


    public class stockDetailsUpdateDALDataParameters
    {


        private StockDetails _stockDetails;


        public stockDetailsUpdateDALDataParameters(StockDetails stockdetails)
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

