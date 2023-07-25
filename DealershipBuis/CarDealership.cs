using CarDealership.CarBrands;
using CarDealership.Observer;
using DesignPatterns.IteratorExample;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CarDealership.DealershipBuis
{
    public class CarDealership : ADealership<Car>
    {
        
        private static CarDealership _ds;
        private void RegisterObservers()
        {
            VehicleBrand[] brands = new VehicleBrand[] { VehicleBrand.Toyota, VehicleBrand.Honda, VehicleBrand.Ford, VehicleBrand.BMW };
            foreach (var brand in brands)
            {
                ((ISubject)this).Attach(brand);
            }
        }
        #region Init
        private CarDealership()
        {
            RegisterObservers();
            InitList();
        }

        public static CarDealership GetInstace()
        {
            if (_ds == null) { _ds = new CarDealership(); }
            return _ds;
        }
        private void InitList()
        {
            AddVehicle(new Car(2023, 5, 200, 105000, VehicleBrand.Toyota, "Camry"));
            AddVehicle(new Car(2022, 4, 180, 87500, VehicleBrand.Honda, "Civic"));
            AddVehicle(new Car(2023, 5, 250, 122500, VehicleBrand.Ford, "Mustang"));
            AddVehicle(new Car(2021, 5, 150, 77000, VehicleBrand.Toyota, "Corolla"));
            AddVehicle(new Car(2023, 4, 190, 98000, VehicleBrand.Honda, "Accord"));
            AddVehicle(new Car(2022, 5, 300, 140000, VehicleBrand.BMW, "M3"));
            AddVehicle(new Car(2023, 4, 220, 112000, VehicleBrand.Ford, "Fusion"));
            AddVehicle(new Car(2022, 5, 280, 133000, VehicleBrand.BMW, "X5"));
            AddVehicle(new Car(2023, 5, 230, 122500, VehicleBrand.Toyota, "Rav4"));
            AddVehicle(new Car(2023, 5, 200, 112000, VehicleBrand.Ford, "Escape"));
        }
        #endregion

        public void SellCar()
        {
            Console.WriteLine("Enter The CarInd: ");
            int carInd = int.Parse(Console.ReadLine());
            Car car = (Car)_vehicles[carInd - 1];
            car.DisplayVehicleInfo();
            RemoveVehicle(car);
            Console.WriteLine("\n--Car Sold--");
            ((Observer.ISubject)this).Notify(car.Brand); // Notify observers after a car is sold.
        }

        protected override void VheicleToString(Car vheicle)
        {
            vheicle.DisplayVehicleInfo();
        }

        public override int CountCarsByBrand(string brandName)
        {
            return _vehicles.Count(v => v.Brand.Name == brandName);
        }
    }
}
