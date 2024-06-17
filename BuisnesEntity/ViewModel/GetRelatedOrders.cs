using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.ViewModel
{
    public class GetRelatedOrders
    {
        public int OrderNumber { get; set; }

        public string PersonName { get; set; }

        public DateTime OrderDate { get; set; }

        public long TotalPrice { get; set; }
    }
}
