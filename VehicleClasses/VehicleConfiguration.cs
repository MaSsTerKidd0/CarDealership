using CarDealership.CarBrands;

namespace CarDealership.VehicleClasses
{
    //TODO: Replace The fields of VehicleBrand with this one instances
    public class VehicleConfiguration
    {
        public int Year { get; set; }
        public int SeatingCapacity { get; set; }
        public int HorsePower { get; set; }
        public int Price { get; set; }
        public AVehicleBrand Brand { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
    }
}
