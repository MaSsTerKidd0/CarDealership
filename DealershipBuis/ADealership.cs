using CarDealership.CarBrands;
using CarDealership.Observer;
using DesignPatterns.IteratorExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.DealershipBuis
{
    public abstract class ADealership<TVheicle> : ISubject
    {
        protected List<TVheicle> _vehicles = new List<TVheicle>();
        private List<IObserver> _observers = new List<IObserver>();

        protected void AddVehicle(TVheicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        protected void RemoveVehicle(TVheicle vehicle)
        {
            _vehicles.Remove(vehicle);
        }

        public abstract int CountCarsByBrand(string brandName);

        public void AvailableCars()
        {
            CircularIterator<TVheicle> iterator = new CircularIterator<TVheicle>(_vehicles);
            int counter = 1;
            if (_vehicles.Count == 0)
            {
                Console.WriteLine("No cars available in the dealership.");
                return;
            }

            Console.WriteLine("Available cars in the dealership:");
            do
            {
                Console.Write($"{counter++}.");
                VheicleToString(iterator.Current);
                iterator.Next();
            } while (!(iterator.Current.Equals(_vehicles.First())));
        }

        protected abstract void VheicleToString(TVheicle vheicle);

        void ISubject.Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        void ISubject.Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        void ISubject.Notify(VehicleBrand vehiclebrand)
        {
            vehiclebrand.Update(this);
        }
    }
}
