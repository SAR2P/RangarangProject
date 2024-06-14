

namespace BuisnesEntityLayer.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public float Price { get; set; }


        public int ProductId { get; set; }
        public ProductE ProductE { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public float SumPrice { get; set; }
    }
}
