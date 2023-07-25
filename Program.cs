using System;
using System.Security.Cryptography;
using CarDealership.DealershipBuis;

namespace CarDealership
{
    internal class Program
    {
        static DealershipBuis.CarDealership ds = DealershipBuis.CarDealership.GetInstace();
        static Dictionary<ConsoleKey, Action> dsActions = new Dictionary<ConsoleKey, Action>() 
        {
            { ConsoleKey.A, ds.AvailableCars},
            { ConsoleKey.B, ds.SellCar}
        };
        public static void Main(string[] args)
        {
            DealerShipMenu();
        }

        public static void DealerShipMenu() 
        {
            ConsoleKeyInfo keyPressed;
            do
            {
                Console.WriteLine("A.Car Listing");
                Console.WriteLine("B.Buy Car");
                Console.Write("Please Enter your choice: ");
                keyPressed = Console.ReadKey(false);
                Console.WriteLine("");
                if (dsActions.ContainsKey(keyPressed.Key)) { dsActions[keyPressed.Key](); }
            } while (keyPressed.Key != ConsoleKey.Escape);
        }
    }
}