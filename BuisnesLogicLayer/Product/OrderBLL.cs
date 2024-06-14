using BuisnesEntityLayer.Entities;
using DataAccessLayer.Models;


namespace BuisnesLogicLayer.Product
{
    public class OrderBLL
    {
        OrderDAL pro = new OrderDAL();

        public bool CreateOrder(Order order)
        {
            try
            {

                pro.createOrder(order);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public int GetNewNumberForOrder()
        {
          
                var counting = GetAll().Count();
                return counting + 1;
           
        }

        public List<Order> GetAll()
        {
            var result = pro.ReadOrders();
            return result;
        }

        public Order GetProductById(int id)
        {
            var result = pro.GetProductById(id);
            return result;
        }

        public int getOrederIdByNumber(int id)
        {
            var res = pro.GetOrderIdByNumber(id);
            return res;
        }

    }
}
