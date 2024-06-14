using BuisnesEntityLayer.Entities;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class OrderDetailsDAL
    {

        RangarangDbContext ctx = new RangarangDbContext();


        public void createOrderDetails(OrderDetails OrderDetail)
        {
            ctx.OrderDetails.Add(OrderDetail);
            ctx.SaveChanges();
        }

        public List<OrderDetails> ReadOrderDetails()
        {
            return ctx.OrderDetails.ToList();
        }

       

        public OrderDetails ReadByOrderDetailsID(int id)
        {
            var query = ctx.OrderDetails.FirstOrDefault(h => h.Id == id);
            return query;
        }


        public void UpdateOrderDetailsById(int id, OrderDetails NewOrderDetails)
        {
            var query = ctx.OrderDetails.Where(h => h.Id == id);

            if (query.Count() == 1)
            {
                OrderDetails NOrderDetails = new OrderDetails();

                NOrderDetails = query.Single();
                NOrderDetails.Count = NewOrderDetails.Count;
                NOrderDetails.Price = NewOrderDetails.Price;
                NOrderDetails.ProductEId = NewOrderDetails.ProductEId;
                NOrderDetails.OrderId = NewOrderDetails.OrderId;
                ctx.SaveChanges();

            }
        }

        public void DeletProductById(int id)
        {
            var query = from i in ctx.OrderDetails where i.Id == id select i;

            if (query.Count() == 1)
            {
                ctx.OrderDetails.Remove(query.Single());
                ctx.SaveChanges();

            }
        }
    }
}
