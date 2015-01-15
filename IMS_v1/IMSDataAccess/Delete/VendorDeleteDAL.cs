using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Delete
{
    public class VendorDeleteDAL : DataAccessbase
    {
        VendorDeleteDALDataparameters _insertParameters;
        public VendorDeleteDAL()
        {
            StoredProcedureName = StoredProcedure.Delete.Sp_DeleteVendor.ToString();
        }
        public void Delete(Vendor val)
        {

            _insertParameters = new VendorDeleteDALDataparameters(val);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }

    public class VendorDeleteDALDataparameters
    {

        public VendorDeleteDALDataparameters(Vendor val)
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

        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
        private Vendor _vDetail;

        public Vendor VDetail
        {
            get { return _vDetail; }
            set { _vDetail = value; }
        }
    }

}
