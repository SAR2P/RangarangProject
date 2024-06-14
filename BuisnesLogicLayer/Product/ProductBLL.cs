using BuisnesEntityLayer.Entities;
using DataAccessLayer.Models;

namespace BuisnesLogicLayer.Product
{
    public class ProductBLL
    {
        ProductDAL pro = new ProductDAL();

        public List<ProductE> GetAll()
        {
            var result = pro.Read();
            return result;
        }

        public ProductE GetProductById(int id)
        {
            var result = pro.ReadByProductID(id);
            return result;
        }

        



    }
}
