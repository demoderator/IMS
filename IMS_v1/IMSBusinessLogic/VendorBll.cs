using IMSCommon;
using IMSDataAccess.Delete;
using IMSDataAccess.Insert;
using IMSDataAccess.Select;
using IMSDataAccess.Update;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSBusinessLogic
{
    public class VendorBll
    {
        public static DataSet GetAllVendor()
        {

            DataSet resultSet = new DataSet();

            VendorSelect categoryInstance = new VendorSelect();
            resultSet = categoryInstance.View();

            return resultSet;
        }




        public static DataSet GetAllVendorById(Vendor val)
        {

            DataSet resultSet = new DataSet();

            VendorSelectByID vendorInstance = new VendorSelectByID();
            resultSet = vendorInstance.View(val);

            return resultSet;
        }
        public void Update(Vendor ven)
        {
            VendorUpdateDAL vendorInstance = new VendorUpdateDAL();
            vendorInstance.Update(ven);
        }

        public void Delete(Vendor ven)
        {
            VendorDeleteDAL vendorInstance = new VendorDeleteDAL();
            vendorInstance.Delete(ven);
        }

        public void Add(Vendor ven)
        {
            VendorInsertDAL vendorInstance = new VendorInsertDAL();
            vendorInstance.Add(ven);
        }
    }
}
