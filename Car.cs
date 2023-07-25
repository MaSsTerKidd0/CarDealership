using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.CarBrands;

namespace CarDealership
{
    public class Car : AVehicle
    {
        private const int WHEELAMOUNT = 4;

        public Car(int year, int seatingCapcity, int horsePower, int price, VehicleBrand brand, string model)
            : base(year, seatingCapcity, horsePower, WHEELAMOUNT, price, brand, model)
        {

        }

        public override void DisplayVehicleInfo()
        {
            Console.WriteLine("This Is Car: ");
            base.DisplayVehicleInfo();
        }
    }
}
