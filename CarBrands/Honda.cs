using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.CarBrands
{
    public class Honda : VehicleBrand
    {
        public Honda() : base("Honda", "Japan", 1948)
        {
            Manager = "Jane Smith";
            MinimumInShop = 0;
        }
    }
}
