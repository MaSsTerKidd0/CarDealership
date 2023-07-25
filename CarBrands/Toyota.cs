using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.CarBrands
{
    public class Toyota : VehicleBrand
    {
        public Toyota() : base("Toyota", "Japan", 1937)
        {
            Manager = "John Doe";
            MinimumInShop = 2;
        }
    }
}
