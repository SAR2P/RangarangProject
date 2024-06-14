using BuisnesEntityLayer.Entities;
using DataAccessLayer.Context;


namespace DataAccessLayer.Models
{
    public class ProductDAL
    {

        RangarangDbContext ctx = new RangarangDbContext();


        public void createProduct(ProductE c)
        {
            ctx.Products.Add(c);
            ctx.SaveChanges();
        }

        public List<ProductE> Read()
        {
            return ctx.Products.ToList();
        }

        public List<ProductE> ReadByProductName(string ProductName)
        {
            var q = ctx.Products.Where(h => h.Name == ProductName);

            return q.ToList();
        }

        public ProductE ReadByProductID(int id)
        {
            var query = ctx.Products.FirstOrDefault(h => h.Id == id);
            return query;
        }


        public void UpdateProductById(int id, ProductE NewProduct)
        {
            var query = ctx.Products.Where(h => h.Id == id);

            if (query.Count() == 1)
            {
                ProductE NProduct = new ProductE();

                NProduct = query.Single();
                NProduct.Name = NewProduct.Name;
                NProduct.Price = NewProduct.Price;
                NProduct.Code = NewProduct.Code;
                ctx.SaveChanges();

            }
        }

        public void DeletProductById(int id)
        {
            var query = from i in ctx.Products where i.Id == id select i;

            if (query.Count() == 1)
            {
                ctx.Products.Remove(query.Single());
                ctx.SaveChanges();

            }


        }




    }
}
