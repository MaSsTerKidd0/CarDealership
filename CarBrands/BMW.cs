using CarDealership.CarTests;
using CarDealership.VehicleClasses;

namespace CarDealership.CarBrands
{
    public class BMW : VehicleBrand
    {

        public BMW() : base("BMW", "Germany", 1916)
        {
            Manager = "Michael Schmidt";
            MinimumInShop = 3;
            _models = new List<string> { "X5", "X3", "3 Series", "5 Series", "7 Series", "i8", "Z4" };
            _types = new List<string> { "M3", "X7" };
            _test = new BMWTest();
            _brand = this;
        }

        protected override Car GenerateBrandVehicle()
        {
            CarBuilder builder = new CarBuilder();
            BuildVehicle(builder);
            return builder.GetProduct();
        }

    }
}
