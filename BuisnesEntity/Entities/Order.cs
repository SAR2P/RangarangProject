using BuisnesEntityLayer.baseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.Entities
{
    public class Order : BaseEntities
    {
        
        public int Number { get; set; }
        public DateTime Date { get; set; }

        
        public int PersonId { get; set; }
        public Person Person { get; set; }


    }
}
