using CarDealership.VehicleClasses;

namespace CarDealership.CarBrands
{
    public class Ford : VehicleBrand
    {
        public Ford() : base("Ford", "USA", 1903)
        {
            Manager = "Tom Johnson";
            MinimumInShop = 1;
            _models = new List<string> { "Fiesta", "Focus", "Mustang", "Escape", "Explorer", "Expedition", "Ranger" };
            _types = new List<string> { "Fusion", "Explorer Sport" };
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
