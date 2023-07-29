using CarDealership.CarBrands;
using CarDealership.VehicleClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class PrintManager
    {

        public static void PrintMenu()
        {
            Console.WriteLine("A. Car Listing");
            Console.WriteLine("B. Buy Car");
            Console.WriteLine("C. Test Car");
            Console.WriteLine("D. Repalce Car Part");
            Console.Write("Please Enter your choice: ");
        }
        public static void NewLine()
        {
            Console.WriteLine();
        }

        public static void PartCatalog()
        {
            Console.WriteLine("Catalog:");
            Console.WriteLine("1.Engine");
            Console.WriteLine("2.Battery");
            Console.Write("Pick:");
        }

        public static void DisplayVehicleInfo(AVehicle vehicle)
        {
            Console.WriteLine("\nVehicle Information:");
            Console.WriteLine($"Brand: {vehicle.Brand.Name}");
            Console.WriteLine($"Year: {vehicle.Year}");
            Console.WriteLine($"Seating Capacity: {vehicle.SeatingCapacity}");
            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
            Console.WriteLine($"Wheels Amount: {vehicle.WheelsAmount}");
            Console.WriteLine($"Price: {vehicle.Price:N0}ILS");
            Console.WriteLine($"Model: {vehicle.Model}");
            Console.WriteLine($"Type: {vehicle.Typ}");
            Console.WriteLine($"Engine: {vehicle.VehicleEngine.Name}");
            Console.WriteLine($"Battery: {vehicle.VehicleBattery.Name}\n");
        }

        public static void VehicleSoldMessage()
        {
            Console.WriteLine("---!!!Vehicle Sold!!!---");
        }
        public static void AskVehicleId()
        {
            Console.WriteLine("Enter The CarInd: ");
        }
        public static void IndreduceClientVehicle()
        {
            Console.WriteLine("Client Vehicle -> ");
        }
        public static void AskVehicleChange()
        {
            Console.WriteLine("Please Choose replacement: ");
        }

        public static void VehicleAfterChange()
        {
            Console.WriteLine("Client Car After Change: ");
        }
        public static void CarToCheck() 
        {
            Console.Write("Pick Car to check: ");
        }
        public static void NoAvailableCars() 
        {
            Console.WriteLine("No cars available in the dealership.");
        }
        public static void AvailableCars()
        {
            Console.WriteLine("Available cars in the dealership:");
        }
    }
}
