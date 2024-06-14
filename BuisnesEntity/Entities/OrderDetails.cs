

namespace BuisnesEntityLayer.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public long Price { get; set; }

        public long SumPrice { get; set; }

        public int ProductEId { get; set; }
        public ProductE ProductE { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

       
    }
}
