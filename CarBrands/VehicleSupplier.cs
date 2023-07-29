using CarDealership.CarTests;
using CarDealership.VehicleClasses;
using CarDealership.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.CarBrands
{
    public class VehicleSupplier
    {
        private static Random random = new Random();
        public static List<AVehicle> VehicleProducer(int count, AVehicleBrand brand)
        {
            List<AVehicle> brandVehicles = new List<AVehicle>();
            brand.CurrentCarsInShop += count;
            for (int i = 0; i < count; i++)
            {
                brandVehicles.Add(brand.GenerateBrandVehicle());
            }
            return brandVehicles;
        }

        public static void BuildVehicle(IVehicleBuilder builder, AVehicleBrand brand)
        {
            builder.Reset();
            builder.SetYear(random.Next(2015, 2023));
            builder.SetSeatingCapacity(random.Next(4, 6));
            builder.SetHorsePower(random.Next(200, 400));
            builder.SetPrice(random.Next(30000, 100000));
            builder.SetBrand(brand);
            builder.SetTest(brand._test);
            builder.SetType(brand._types[random.Next(0, brand._types.Count)]);
            builder.SetModel(brand._models[random.Next(0, brand._models.Count)]);
            builder.SetEngine((Engine)brand._brandParts["Engines"][random.Next(0, brand._brandParts["Engines"].Count)]);
            builder.SetBattery((Battery)brand._brandParts["Batterys"][random.Next(0, brand._brandParts["Batterys"].Count)]);
        }

        
    }
}
