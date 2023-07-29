using CarDealership.CarTests;
using CarDealership.VehicleClasses;
using CarDealership.VehicleParts;
using System.Runtime.Intrinsics.X86;

namespace CarDealership.CarBrands
{
    public class BMW : AVehicleBrand
    {
        public BMW() : base("BMW", "Germany", 1916)
        {
            Manager = "Michael Schmidt";
            MinimumInShop = 3;
            _models = new List<string> { "X5", "X3", "3 Series", "5 Series", "7 Series", "i8", "Z4" };
            _types = new List<string> { "M3", "X7" };
            _test = new BMWTest();
            _brand = this;

            _enginesTypes = new List<string>() { "BMWE1", "BMWE2", "BMWE3" };
            _batteryTypes = new List<string> { "BMWBattery1", "BMWBattery2" };
            _brandParts["Engines"].AddRange(PartsSupplier.GenerateEngines(this, _enginesTypes));
            _brandParts["Batterys"].AddRange(PartsSupplier.GenerateBatterys(this, _batteryTypes));
        }

        public override Car GenerateBrandVehicle()
        {
            CarBuilder builder = new CarBuilder();
            VehicleSupplier.BuildVehicle(builder, this);
            return builder.GetProduct();
        }

    }
}
