using CarDealership.VehicleClasses;

namespace CarDealership.CarBrands
{
    public class Honda : VehicleBrand
    {
        public Honda() : base("Honda", "Japan", 1948)
        {
            Manager = "Jane Smith";
            MinimumInShop = 2;
            _models = new List<string> { "Civic", "Accord", "CR-V", "Pilot", "Odyssey", "HR-V", "Ridgeline" };
            _types = new List<string> { "Fit", "Civic Type R" };
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
