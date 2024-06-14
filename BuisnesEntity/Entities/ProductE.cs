using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.Entities
{
    public class ProductE
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public float Price { get; set; } 
        public int Code { get; set; } 
    }
}
