using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Select
{
    public class VendorSelectByID : DataAccessbase
    {
        VendorSelectByIDDataParameter _insertParameters;
        public VendorSelectByID()
        {
            StoredProcedureName = StoredProcedure.Select.Sp_GetVendorById.ToString();
        }


        public DataSet View(Vendor val)
        {
            DataSet ds;
            _insertParameters = new VendorSelectByIDDataParameter(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, _insertParameters.Parameters);
            return ds;
        }
    }


    public class VendorSelectByIDDataParameter
    {

        public VendorSelectByIDDataParameter(Vendor val)
        {
            VDetail = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@p_Supp_ID", VDetail.supp_ID) };
            Parameters = parameters;
        }
        private SqlParameter[] _parameters;
        private Vendor _vDetail;

        public Vendor VDetail
        {
            get { return _vDetail; }
            set { _vDetail = value; }
        }

        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
