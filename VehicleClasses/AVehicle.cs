using CarDealership.CarBrands;
using CarDealership.CarTests;

namespace CarDealership.VehicleClasses
{
    public abstract class AVehicle
    {
        #region fields
        public int Year { get; set; }
        public int SeatingCapacity { get; set; }
        public int HorsePower { get; set; }
        public int WheelsAmount { get; set; }
        public int Price { get; set; }
        public VehicleBrand Brand { get; set; }
        public string Model { get; set; }
        public string Typ { get; set; }
        public ITest Test { get; set; }

        #endregion


        public virtual void DisplayVehicleInfo()
        {
            Console.WriteLine("Vehicle Information:");
            Console.WriteLine($"Brand: {Brand.Name}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Seating Capacity: {SeatingCapacity}");
            Console.WriteLine($"Horsepower: {HorsePower}");
            Console.WriteLine($"Wheels Amount: {WheelsAmount}");
            Console.WriteLine($"Price: {Price:N0}ILS");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Type: {Typ}");
            Console.WriteLine();
        }

        public void PerformVehicleTest()
        {
            if (Test != null)
            {
                PerformTest();
                Test.PerformEngineTest();
                Test.PerformAirPollutionTest();
                Test.PerformDriveTest();
            }
        }
        public abstract void PerformTest();

    }
}
