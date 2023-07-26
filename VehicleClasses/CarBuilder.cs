using CarDealership.CarBrands;
using CarDealership.CarTests;
using CarDealership.VehicleParts;

namespace CarDealership.VehicleClasses
{
    public class CarBuilder : IVehicleBuilder
    {
        //TODO: CarBuilder can be refactor to be Generic? or by using abstract call AVehicle
        private Car car;

        public CarBuilder()
        {
            Reset();
        }
        #region Builder Setters
        public void Reset()
        {
            car = new Car();
        }

        public void SetYear(int year)
        {
            car.Year = year;
        }

        public void SetSeatingCapacity(int seatingCapacity)
        {
            car.SeatingCapacity = seatingCapacity;
        }

        public void SetHorsePower(int horsePower)
        {
            car.HorsePower = horsePower;
        }

        public void SetPrice(int price)
        {
            car.Price = price;
        }

        public void SetBrand(AVehicleBrand brand)
        {
            car.Brand = brand;
        }

        public void SetModel(string model)
        {
            car.Model = model;
        }

        public Car GetProduct()
        {
            return car;
        }

        public void SetType(string typ)
        {
            car.Typ = typ;
        }
        public void SetTest(ITest test)
        {
            car.Test = test;
        }
        public void SetEngine(Engine en)
        {
            car.VehicleEngine = en;
        }
        public void SetBattery(Battery battery)
        {
            car.VehicleBattery = battery;
        }
        #endregion

    }
}
