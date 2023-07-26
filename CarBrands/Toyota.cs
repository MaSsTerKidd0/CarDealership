using CarDealership.VehicleClasses;

namespace CarDealership.CarBrands
{
    public class Toyota : VehicleBrand
    {
        public Toyota() : base("Toyota", "Japan", 1937)
        {
            Manager = "John Doe";
            MinimumInShop = 2;
            _models = new List<string> { "Corolla", "Camry", "Rav4", "Highlander", "4Runner", "Sienna", "Tacoma" };
            _types = new List<string> { "Prius", "Supra" };
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
