using CarDealership.CarBrands;
using CarDealership.VehicleParts;
using System.Diagnostics;
using System.Xml.Linq;

namespace CarDealership
{
    public class PartsSupplier
    {
        private static Random random = new Random();

        //TODO: make colaboral function then use the spicify builder
        public static void BuildEngine(EngineBuilder engineBuilder, int price, AVehicleBrand brand, int warranty, string name, int smk)
        {
            BuildVehiclePart(engineBuilder, price, brand, warranty, name);
            engineBuilder.SetEngineSmk(smk);
        }
        public static void BuildBattery(BatteryBuilder batteryBuilder, int price, AVehicleBrand brand, int warranty, string name, int voltage)
        {
            BuildVehiclePart(batteryBuilder, price, brand, warranty, name);
            batteryBuilder.SetVoltage(voltage);
        }
        private static void BuildVehiclePart(IVehiclePartBuilder builder, int price, AVehicleBrand brand, int warranty, string name) 
        {
            builder.Reset();
            builder.SetBrand(brand);
            builder.SetPrice(price);
            builder.SetWarranty(warranty);
            builder.SetName(name);
        }

        public static List<Engine> GenerateEngines(AVehicleBrand brand, List<string> enginesList)
        {
            EngineBuilder builder = new EngineBuilder();
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < enginesList.Count; i++)
            {
                BuildEngine(builder, random.Next(5000, 8500), brand, random.Next(1, 3), enginesList[i], random.Next(800, 1500));
                engines.Add(builder.GetProduct());
            }
            return engines;
        }
        public static List<Battery> GenerateBatterys(AVehicleBrand brand, List<string> enginesList)
        {
            BatteryBuilder builder = new BatteryBuilder();
            List<Battery> batteries = new List<Battery>();
            for (int i = 0; i < enginesList.Count; i++)
            {
                BuildBattery(builder, random.Next(5000, 8500), brand, random.Next(1, 3), enginesList[i], random.Next(800, 1500));
                batteries.Add(builder.GetProduct());
            }
            return batteries;
        }

        /*
        public static List<T> GenerateVehicleParts<T>(AVehicleBrand brand, List<string> partNames)
            where T : IVehiclePartBuilder, new()
            {
            List<T> parts = new List<T>();

            for (int i = 0; i < partNames.Count; i++)
            {
                T part = new T();
                part.Reset();
                part.SetBrand(brand);
                part.SetWarranty(random.Next(1, 3));
                part.SetPrice(random.Next(5000, 8500));
                part.SetName(partNames[i]);
                parts.Add(part);
            }

            return parts;
        }*/
    }
}
