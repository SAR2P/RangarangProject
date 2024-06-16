using BuisnesEntityLayer.baseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.Entities
{
    public class ProductE : BaseEntities
    {
        public string Name { get; set; } = string.Empty;

        public long Price { get; set; } 
        public int Code { get; set; } 
    }
}
