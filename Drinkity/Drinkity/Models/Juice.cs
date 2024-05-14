using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkity.Models
{
    public class Juice: Drinks
    {
         public string Fruit;
        public override string GetDrinks()
        {
            string carbonatedStatus = IsCarbonated ? "Carbonated" : "Not Carbonated";
            return $"{Name}, {carbonatedStatus}, Made from {Fruit}";
        }
        public Juice(string name, string fruit) : base(name, false)
        {
            Fruit = fruit;
        }
    }
}