using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IMSDataAccess.Update
{
    public class VendorUpdateDAL : DataAccessbase
    {
        VendorUpdateDALDataParameters _insertParameters;

        public VendorUpdateDAL()
        {
            StoredProcedureName = StoredProcedure.Update.Sp_UpdateVendor.ToString();
        }
        public void Update(Vendor ven)
        {

            _insertParameters = new VendorUpdateDALDataParameters(ven);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            dbHelper.Run(base.ConnectionString, _insertParameters.Parameters);
        }

    }



    public class VendorUpdateDALDataParameters
    {


        public VendorUpdateDALDataParameters(Vendor val)
        {
            VDetail = val;
            Build();
        }
        public void Build()
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@p_Supp_ID", VDetail.supp_ID),
                                         new SqlParameter("@p_SupName", VDetail.SupName),
                                          new SqlParameter("@p_Address", VDetail.address),
                                           new SqlParameter("@p_City", VDetail.city),
                                            new SqlParameter("@p_State", VDetail.State),
                                             new SqlParameter("@p_Country", VDetail.Country),
                                              new SqlParameter("@p_Pincode", VDetail.Pincode),
                                               new SqlParameter("@p_Phone", VDetail.Phone),
                                                new SqlParameter("@p_Fax", VDetail.Fax),
                                                new SqlParameter("@p_Mobile", VDetail.Mobile),
                                               new SqlParameter("@p_Pager", VDetail.Pager),
                                               new SqlParameter("@p_Email", VDetail.Email),
                                               new SqlParameter("@p_ConPerson", VDetail.ConPerson),
                                               new SqlParameter("@p_Discount", VDetail.Discount),
                                               new SqlParameter("@p_Credit", VDetail.Credit),
                                               new SqlParameter("@p_LineID", VDetail.LineID),
                                            new SqlParameter("@p_DateCreated", VDetail.DateCreated)
                                        
                                        
                                        
                                        };
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
