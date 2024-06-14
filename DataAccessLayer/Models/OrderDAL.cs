using BuisnesEntityLayer.Entities;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class OrderDAL
    {

        RangarangDbContext ctx = new RangarangDbContext();


        public void createOrder(Order Order)
        {
            ctx.Orders.Add(Order);
            ctx.SaveChanges();
        }

        public List<Order> ReadOrders()
        {
            return ctx.Orders.ToList();
        }

        public Order GetProductById(int id)
        {
            var q = ctx.Orders.Where(h => h.Id == id);

            return q.SingleOrDefault();
        }

        //

        public int GetOrderIdByNumber(int Num)
        {
            var query = ctx.Orders.FirstOrDefault(h => h.Number == Num);
            return query.Id;
        }


        public void UpdateProductById(int id, Order NewOrder)
        {
            var query = ctx.Orders.Where(h => h.Id == id);

            if (query.Count() == 1)
            {
                Order NOrder = new Order();

                NOrder = query.Single();
                NOrder.Number = NewOrder.Number;
                NOrder.Date = NewOrder.Date;
                NOrder.PersonId = NewOrder.PersonId;
                ctx.SaveChanges();

            }
        }

        public void DeletProductById(int id)
        {
            var query = from i in ctx.Orders where i.Id == id select i;

            if (query.Count() == 1)
            {
                ctx.Orders.Remove(query.Single());
                ctx.SaveChanges();

            }


        }

    }
}
