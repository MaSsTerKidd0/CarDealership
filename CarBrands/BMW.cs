using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.CarBrands
{
    public class BMW : VehicleBrand
    {
        public BMW() : base("BMW", "Germany", 1916)
        {
            Manager = "Michael Schmidt";
            MinimumInShop = 1;
        }
    }
}
