using BuisnesEntityLayer.Entities;
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





    }
}
