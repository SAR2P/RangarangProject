using BuisnesEntityLayer.Entities;
using BuisnesLogicLayer.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utility
{
    public static class UtilityOne
    {
        public static List<ProductE> utilityProduct { get; set; } = new List<ProductE>();

        public static AddProductViewModel utilityOneViewForData { get; set; } 
        public static List<AddProductViewModel> utilityViewsForDataGrid { get; set; } = new List<AddProductViewModel>();



    }
}
