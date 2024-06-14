using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.ViewModel
{
    public class AddProductOrderDetailsViewModel
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Count { get; set; }

        public long OneProductPrice { get; set; }

        public long Price { get; set; }

        public bool EditStatus { get; set; } = false;

    }
}
