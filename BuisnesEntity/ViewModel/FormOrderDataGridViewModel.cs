using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.ViewModel
{
    public class FormOrderDataGridViewModel
    {
        public int ProductEId { get; set; }
        public string ProductName { get; set; }

        public int ProductCode { get; set; }

        public long PPrice { get; set; }

        public int count { get; set; }

        public long TotalPrice { get; set; }

    }
}
