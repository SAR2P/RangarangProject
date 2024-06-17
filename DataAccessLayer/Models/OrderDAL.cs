using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

        public List<Order> GetOrders()
        {
            return  ctx.Orders.ToList();
        }

        public Order GetOrdersById(int id)
        {
            var q = ctx.Orders.Where(h => h.Id == id);

            return q.SingleOrDefault();
        }


        public  List<GetRelatedOrders> GetListOffRelatedsToOrder()
        {
            List<GetRelatedOrders> getRelatedOrders = new List<GetRelatedOrders>();

            var orders =  GetOrders();

            foreach (var item in orders)
            {
              
                var perName =  ctx.Person.Where(p => p.Id == item.PersonId).FirstOrDefault();
                var ordersRealatedToOrder = ctx.OrderDetails.Where(o => o.OrderId ==  item.Id).ToList();
                long SumOfOrdersPrice = 0;
                foreach (var i in ordersRealatedToOrder)
                {
                    SumOfOrdersPrice += i.SumPrice;
                }
                getRelatedOrders.Add(new GetRelatedOrders
                {
                    OrderNumber = item.Number,
                    PersonName = perName.Name,
                    TotalPrice = SumOfOrdersPrice,
                    OrderDate = item.Date
                });
              
                
            }
            return getRelatedOrders;
           
        }

        //

        public bool CheckOrderExist(int id)
        {
            var order = ctx.Orders.Where(o => o.Id == id).ToList();
            if (order.Count <= 0)
            {
                return false;
            }
            return true;
        }

        public int GetOrderIdByNumber(int Num)
        {
            var query = ctx.Orders.FirstOrDefault(h => h.Number == Num);
            return query.Id;
        }

        public Order getOrderObjByNumber(int Num)
        {
            var query = ctx.Orders.Where(o => o.Number == Num).SingleOrDefault();
            return query;
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

        public int GetMaxNumberProperty()
        {
            try
            {
                int maxNum = ctx.Orders.Max(h => (int)h.Number);

                return maxNum + 1;
            }
            catch (Exception)
            {
                return 1;
            }
           
            
           
        }

    }
}
