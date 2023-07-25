using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.CarBrands
{
    public class Ford : VehicleBrand
    {
        public Ford() : base("Ford", "USA", 1903)
        {
            Manager = "Tom Johnson";
            MinimumInShop = 0;
        }
    }

}
