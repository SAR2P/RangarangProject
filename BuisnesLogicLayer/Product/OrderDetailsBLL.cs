using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class OrderDetailsBLL
    {
        OrderDetailsDAL OrderDetailsDAL = new OrderDetailsDAL();


       public void createOrderDetails(OrderDetails orderDetails)
        {
            OrderDetailsDAL.createOrderDetails(orderDetails);

        }

        public bool checkIfOrderDetailsExist(int OrderDetailsId)
        {
            return OrderDetailsDAL.CheckIfOrderDetailsExist(OrderDetailsId);
        }


        public List<OrderDetails> GetOrderDetailsByOrderId(int id)
        {
           return OrderDetailsDAL.GetOrderDetailsByOrderId(id);
        }

        public OrderDetails GetOrderDetailsByID(int id)
        {
            return OrderDetailsDAL.GetOrderDetailsByID(id);
            
        }


        public List<OverAllFactorViewModel> GetOverAllDataGridData()
        {
            return OrderDetailsDAL.GetOverAllDataGridData();
        }


        public bool UpdateOrderDetails(int id, OrderDetails orderDetails)
        {
            try
            {
                OrderDetailsDAL.UpdateOrderDetailsById(id, orderDetails);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteOrderDetails(int id)
        {
            try
            {
                OrderDetailsDAL.DeletProductById(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }
    }
}
