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

        public List<string> _models { get; protected set; }
        public List<string> _types { get; protected set; }
        private Random random = new Random();
        public ITest _test { get; protected set; } = new VehicleTest();
        protected AVehicleBrand _brand;
        public Dictionary<string, List<AVehiclePart>> _brandParts { get; protected set; } = new Dictionary<string, List<AVehiclePart>>()
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

        public List<AVehiclePart> GetBrandParts(string part)
        {
            return _brandParts[part];
        }

        public abstract AVehicle GenerateBrandVehicle();
    }
}
