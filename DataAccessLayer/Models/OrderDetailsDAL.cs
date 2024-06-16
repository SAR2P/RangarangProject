using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;


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

        public List<OverAllFactorViewModel> GetOverAllDataGridData()
        {
            List<OrderDetails> orderDetails = ReadOrderDetails();

            List<OverAllFactorViewModel> ki = new List<OverAllFactorViewModel>();
            foreach (var item in orderDetails)
            {
                item.Order = ctx.Orders.Where(o => o.Id == item.OrderId).FirstOrDefault();
                item.Order.Person = ctx.Person.Where(p => p.Id == item.Order.PersonId).FirstOrDefault();
                item.ProductE = ctx.Products.Where(p => p.Id == item.ProductEId).FirstOrDefault();

                ki.Add(new OverAllFactorViewModel
                {
                    OrderDate = item.Order.Date,
                    OrderNumber = item.Order.Number,
                    PersonName = item.Order.Person.Name,
                    OrderDetailsSumPrice = item.SumPrice,
                    OrderDetailsId = item.Id,
                    OrderId = item.OrderId,
                    ProductId = item.ProductEId,
                    ProductName = item.ProductE.Name,
                    ProductPrice = item.ProductE.Price,
                    OrderDetailsCount = item.Count,
                    EditStatus = false
                });
            }
            return ki;
         }






       


        public OrderDetails GetOrderDetailsByID(int id)
        {
            var query = ctx.OrderDetails.Where(h => h.Id == id ).SingleOrDefault();
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
