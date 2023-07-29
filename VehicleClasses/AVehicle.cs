using CarDealership.CarBrands;
using CarDealership.CarTests;
using CarDealership.VehicleParts;

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
        public AVehicleBrand Brand { get; set; }
        public string Model { get; set; }
        public string Typ { get; set; }
        public Engine VehicleEngine { get; set; }
        public Battery VehicleBattery { get; set; }
        public ITest Test { get; set; }

        #endregion
        public virtual void DisplayInfo()
        {
            PrintManager.DisplayVehicleInfo(this);
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
