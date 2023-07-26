using CarDealership.VehicleClasses;

namespace CarDealership.CarBrands
{
    public class Ford : AVehicleBrand
    {
        public Ford() : base("Ford", "USA", 1903)
        {
            Manager = "Tom Johnson";
            MinimumInShop = 1;
            _models = new List<string> { "Fiesta", "Focus", "Mustang", "Escape", "Explorer", "Expedition", "Ranger" };
            _types = new List<string> { "Fusion", "Explorer Sport" };
            _brand = this;

            _enginesTypes = new List<string>() { "FordE1", "FordE2", "FordE3" };
            _batteryTypes = new List<string> { "FordBattery1", "FordBattery2" };
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
