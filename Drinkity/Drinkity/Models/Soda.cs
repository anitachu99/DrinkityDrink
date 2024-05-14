using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkity.Models
{
    public class Soda: Drinks
    {
        public override string GetDrinks()
        {
            string carbonatedStatus = IsCarbonated ? "Carbonated" : "Not Carbonated";
            return $"{Name}, {carbonatedStatus}";
        }
        public Soda(string name) : base(name, true){}
    }
}