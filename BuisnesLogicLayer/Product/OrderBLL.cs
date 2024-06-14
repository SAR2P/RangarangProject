using BuisnesEntityLayer.Entities;
using DataAccessLayer.Models;


namespace BuisnesLogicLayer.Product
{
    public class OrderBLL
    {
        OrderDAL pro = new OrderDAL();

        public void CreateOrder(Order order)
        {
            pro.createProduct(order);
        }

        public List<Order> GetAll()
        {
            var result = pro.ReadOrders();
            return result;
        }

        public Order GetProductById(int id)
        {
            var result = pro.ReadByProductID(id);
            return result;
        }

    }
}
