using CarDealership.CarTests;
using CarDealership.Observer;
using CarDealership.VehicleClasses;

namespace CarDealership.CarBrands
{
    public abstract class VehicleBrand : IObserver
    {
        #region fields
        public string Name { get; }
        public string CountryOfOrigin { get; }
        public int FoundingYear { get; }
        public string Manager { get; set; }
        public int MinimumInShop { get; set; }
        public int CurrentCarsInShop { get; set; } = 0;

        protected List<string> _models;
        protected List<string> _types;
        private static Random random = new Random();
        protected ITest _test = new VehicleTest();
        protected VehicleBrand _brand;
        #endregion

        public VehicleBrand(string name, string countryOfOrigin, int foundingYear)
        {
            Name = name;
            CountryOfOrigin = countryOfOrigin;
            FoundingYear = foundingYear;
        }

        public void Update()
        {
            Console.WriteLine($"Hello, I am {Manager}. Subject: Product Sold Notification - {Name}");

            if (CurrentCarsInShop < MinimumInShop)
            {
                Console.WriteLine($"Alert: {Name} brand has low stock. Ordering more cars...");
            }
        }

        public List<AVehicle> CarProducer(int count)
        {
            List<AVehicle> brandVehicles = new List<AVehicle>();
            CurrentCarsInShop += count;
            for (int i = 0; i < count; i++)
            {
                brandVehicles.Add(GenerateBrandVehicle());
            }
            return brandVehicles;
        }


        public void BuildVehicle(VehicleBuilder builder)
        {
            builder.Reset();
            builder.SetYear(random.Next(2015, 2023));
            builder.SetSeatingCapacity(random.Next(4, 6));
            builder.SetHorsePower(random.Next(200, 400));
            builder.SetPrice(random.Next(30000, 100000));
            builder.SetBrand(_brand);
            builder.SetTest(_test);
            builder.SetType(_types[random.Next(0, _types.Count)]);
            builder.SetModel(_models[random.Next(0, _models.Count)]);
        }

        protected abstract AVehicle GenerateBrandVehicle();
    }
}
