﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesEntityLayer.Entities
{
    public class Order
    {
       

        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; } 

        public int PersonId { get; set; }
        public Person Person { get; set; }


    }
}
