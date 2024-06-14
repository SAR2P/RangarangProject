using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.ViewModel
{
    public class OverAllFactorViewModel
    {

        public string PersonName { get; set; }

        public int OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public int OrderDetailsCount { get; set; }

        public long OrderDetailsSumPrice { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public long ProductPrice { get; set; }

        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
      

        public bool EditStatus { get; set; } = false;




    }
}
