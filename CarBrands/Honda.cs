using CarDealership.VehicleClasses;
using CarDealership.VehicleParts;

namespace CarDealership.CarBrands
{
    public class Honda : AVehicleBrand
    {
        public Honda() : base("Honda", "Japan", 1948)
        {
            Manager = "Jane Smith";
            MinimumInShop = 2;
            _models = new List<string> { "Civic", "Accord", "CR-V", "Pilot", "Odyssey", "HR-V", "Ridgeline" };
            _types = new List<string> { "Fit", "Civic Type R" };
            _brand = this;

            _enginesTypes = new List<string>() { "HondaE1", "HondaE2", "HondaE3" };
            _batteryTypes = new List<string> { "HondaBattery1", "HondaBattery2" };
            _brandParts["Engines"].AddRange(PartsSupplier.GenerateEngines(this, _enginesTypes));
            _brandParts["Batterys"].AddRange(PartsSupplier.GenerateBatterys(this, _batteryTypes));
        }
        protected override Car GenerateBrandVehicle()
        {
            CarBuilder builder = new CarBuilder();
            BuildVehicle(builder);
            return builder.GetProduct();
        }

    }
}
