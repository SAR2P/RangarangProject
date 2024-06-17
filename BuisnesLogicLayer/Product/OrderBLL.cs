using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
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

        public bool CheckOrderExist(int orderId) 
        {
            return pro.CheckOrderExist(orderId);
        }

        public Order GetOrderObjByNumber(int number)
        {
            return pro.getOrderObjByNumber(number);
        }

        public bool UpdateProduct(int id,Order order) 
        {
            try
            {
                pro.UpdateProductById(id, order);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

          


        }

        public int GetNewNumberForOrder()//going to delete
        {
          
                var counting =  GetAll().Count();
                return counting + 1;
        }

        public int GetMaxNumberProperty()
        {
            return pro.GetMaxNumberProperty();
        }

        public List<Order> GetAll()
        {
            var result =  pro.GetOrders();
            return result;
        }

        public List<GetRelatedOrders> GetListOffRelatedsToOrder()
        {
            return pro.GetListOffRelatedsToOrder();
        }

        

        public int getOrederIdByNumber(int id)
        {
            var res = pro.GetOrderIdByNumber(id);
            return res;
        }

        public Order GetOrderById(int id)
        {
            return pro.GetOrdersById(id);
        }

        public bool DeleteOrder(int id)
        {
            try
            {
                pro.DeletProductById(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
