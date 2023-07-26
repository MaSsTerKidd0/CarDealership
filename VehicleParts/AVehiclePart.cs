using CarDealership.CarBrands;

namespace CarDealership.VehicleParts
{
    public class AVehiclePart
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public AVehicleBrand Brand { get; set; }
        public int Warranty { get; set; }
    }
}
