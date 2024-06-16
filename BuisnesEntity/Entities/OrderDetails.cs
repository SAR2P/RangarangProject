

using BuisnesEntityLayer.baseEntity;

namespace BuisnesEntityLayer.Entities
{
    public class OrderDetails : BaseEntities
    {

        public int Count { get; set; }

        public long Price { get; set; }

        public long SumPrice { get; set; }

        public int ProductEId { get; set; }
        public ProductE ProductE { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public bool EditState { get; set; } = false;

    }
}
