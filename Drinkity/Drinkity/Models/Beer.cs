using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkity.Models
{
    public class Beer: Drinks
    {
         public int AlcoholContent;
        public override string GetDrinks()
        {
            string carbonatedStatus = IsCarbonated ? "Carbonated" : "Not Carbonated";
            return $"{Name}, {carbonatedStatus}, {AlcoholContent}%";
        }
        public Beer(string name, int alcoholContent) : base(name, true)
        {
            AlcoholContent = alcoholContent;
        }
    }
}