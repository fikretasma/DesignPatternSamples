using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Meal
{
    public class Meal
    {
        public string Sandwich { get; set; }
        public string SideOrder { get; set; }
        public string Drink { get; set; }
        public string Offer { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4:f2}",
                Sandwich, SideOrder, Drink, Offer, Price);
        }
    }
}
