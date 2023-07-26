using CarDealership.CarTests;
using CarDealership.Observer;
using CarDealership.VehicleClasses;
using CarDealership.VehicleParts;

namespace CarDealership.CarBrands
{
    public abstract class AVehicleBrand : IObserver
    {
        #region fields
        //TODO: get rid of some fields :(
        public string Name { get; }
        public string CountryOfOrigin { get; }
        public int FoundingYear { get; }
        public string Manager { get; set; }
        public int MinimumInShop { get; set; }
        public int CurrentCarsInShop { get; set; } = 0;

        protected List<string> _models;
        protected List<string> _types;
        private Random random = new Random();
        protected ITest _test = new VehicleTest();
        protected AVehicleBrand _brand;
        protected Dictionary<string, List<AVehiclePart>> _brandParts = new Dictionary<string, List<AVehiclePart>>()
        {
            { "Engines", new List<AVehiclePart>() },
            { "Batterys", new List<AVehiclePart>() }
        };
        protected List<string> _enginesTypes;
        protected List<string> _batteryTypes;
        #endregion

        public AVehicleBrand(string name, string countryOfOrigin, int foundingYear)
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
                //TODO: implement order Cars->
                Console.WriteLine($"Alert: {Name} brand has low stock. Ordering more Vehicle...");
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

        public void BuildVehicle(IVehicleBuilder builder)
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
            builder.SetEngine((Engine)_brandParts["Engines"][random.Next(0, _brandParts["Engines"].Count)]);
            builder.SetBattery((Battery)_brandParts["Batterys"][random.Next(0, _brandParts["Batterys"].Count)]);
        }

        protected abstract AVehicle GenerateBrandVehicle();

        public List<AVehiclePart> GetBrandParts(string part) 
        {
            return _brandParts[part];
        }
    }
}
