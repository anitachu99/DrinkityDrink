using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkity.Models
{
    public class Drinks
    {
        public string Name;
        public bool IsCarbonated;

        public string Image;

        public Drinks(string name, bool isCarbonated)
        {
            Name = name;
            IsCarbonated = isCarbonated;
        }
        
        public virtual string GetDrinks()
        {
            string carbonatedStatus = IsCarbonated ? "Carbonated" : "Not Carbonated";
            return $"{Name}, {carbonatedStatus}";
        }
    }
}