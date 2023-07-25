using CarDealership.DealershipBuis;
using CarDealership.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CarDealership.CarBrands
{
    public class VehicleBrand : IObserver
    {
        public string Name { get; }
        public string CountryOfOrigin { get; }
        public int FoundingYear { get; }
        public string Manager { get; set; }
        public int MinimumInShop { get; set; }

        public static readonly VehicleBrand Toyota = new Toyota();
        public static readonly VehicleBrand Honda = new Honda();
        public static readonly VehicleBrand Ford = new Ford();
        public static readonly VehicleBrand BMW = new BMW();

        public VehicleBrand(string name, string countryOfOrigin, int foundingYear)
        {
            Name = name;
            CountryOfOrigin = countryOfOrigin;
            FoundingYear = foundingYear;
        }

        public void Update(ISubject subject)
        {
            if (subject is ADealership<Car> dealership)
            {
                string brandName = Name; // Use the brand's name property from VehicleBrand.
                int currentStock = dealership.CountCarsByBrand(brandName);
                Console.WriteLine($"Hello i am {Manager} Subject: Product Sold Notification - {Name}");

                if (currentStock < MinimumInShop)
                {
                    Console.WriteLine($"Alert: {brandName} brand has low stock. Ordering more cars...");

                }
            }
        }
    }
}
