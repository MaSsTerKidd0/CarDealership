using CarDealership.VehicleClasses;

namespace CarDealership.CarBrands
{
    public class Toyota : AVehicleBrand
    {
        public Toyota() : base("Toyota", "Japan", 1937)
        {
            Manager = "John Doe";
            MinimumInShop = 2;
            _models = new List<string> { "Corolla", "Camry", "Rav4", "Highlander", "4Runner", "Sienna", "Tacoma" };
            _types = new List<string> { "Prius", "Supra" };
            _brand = this;

            _enginesTypes = new List<string>() { "ToyotaE1", "ToyotaE2", "ToyotaE3" };
            _batteryTypes = new List<string> { "ToyotaBattery1", "ToyotaBattery2" };
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
