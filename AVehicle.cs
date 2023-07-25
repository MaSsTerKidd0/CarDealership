using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.CarBrands;

namespace CarDealership
{
    public abstract class AVehicle
    {
        protected int _year;
        protected int _seatingCapacity;
        protected int _horsePower;
        protected int _wheelsAmount;
        protected int _price;
        public VehicleBrand Brand { get; protected set; }
        protected string _model;

        protected AVehicle(int year, int seatingCapcity, int horsePower, int wheelsAmount, int price, VehicleBrand brand, string model)
        {
            _year = year;
            _seatingCapacity = seatingCapcity;
            _horsePower = horsePower;
            _wheelsAmount = wheelsAmount;
            _price = price;
            Brand = brand;
            _model = model;
        }

        public virtual void DisplayVehicleInfo()
        {
            Console.WriteLine("Vehicle Information:");
            Console.WriteLine($"Brand: {Brand.Name}");
            Console.WriteLine($"Year: {_year}");
            Console.WriteLine($"Seating Capacity: {_seatingCapacity}");
            Console.WriteLine($"Horsepower: {_horsePower}");
            Console.WriteLine($"Wheels Amount: {_wheelsAmount}");
            Console.WriteLine($"Price: {_price:N0}ILS");
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine();
        }
    }
}
