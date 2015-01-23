using IMSCommon;
using IMSDataAccess.Delete;
using IMSDataAccess.Update;
using IMSDataAccess.Insert;
using IMSDataAccess.Select;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IMSBusinessLogic
{
  public   class PlaceOrderBLL
    {

      public void Add(OrderDetails val)
      {
          PlaceOrderInsertDAL objDal = new PlaceOrderInsertDAL();
          objDal.Add(val);
      }

      public void AddOrderDetails(OrderDetails val)
      {
          OrderInsertDetail objDal = new OrderInsertDetail();
          objDal.Add(val);
      }

      public static DataSet GetNewOrderDetails(OrderDetails val)
      {
          DataSet resultSet = new DataSet();
          GetPlaceOrderDAL instance = new GetPlaceOrderDAL();
          resultSet = instance.View(val);
          return resultSet;
      }

      public static DataSet GetOrderDetailsById(OrderDetails val)
      {
          DataSet resultSet = new DataSet();
          OrderDetailsByOrderID instance = new OrderDetailsByOrderID();
          resultSet = instance.View(val);
          return resultSet;
      }



      public static DataSet GetPenddingOrders(OrderDetails val)
      {
          DataSet resultSet = new DataSet();
          PendingOrderDAL instance = new PendingOrderDAL();
          resultSet = instance.View(val);
          return resultSet;
      }


      public void Delete(OrderDetails val)
      {
          orderDetailByDetailsIdDeleteDAL instance = new orderDetailByDetailsIdDeleteDAL();
          instance.Delete(val);
      }


      public void update(OrderDetails val)
      {
          orderDetailsUpdateDAL instance = new orderDetailsUpdateDAL();
          instance.Update(val);
      }

      public void updateOrderByStatus(OrderDetails val)
      {
          OrderDetailsUpdateByStatusDAL instance = new OrderDetailsUpdateByStatusDAL();
          instance.Update(val);
      }
     }
}
