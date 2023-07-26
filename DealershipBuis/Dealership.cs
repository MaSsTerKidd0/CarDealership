using CarDealership.CarBrands;
using CarDealership.Observer;
using CarDealership.VehicleClasses;

namespace CarDealership.DealershipBuis
{
    public class Dealership : ISubject
    {
        #region Fields and Properties

        private List<IObserver> _observers = new List<IObserver>();
        private VehicleManager _vehicleManager;
        private ObserverManager _observerManager;
        private VehicleSeller _carSeller;
        private static Dictionary<ConsoleKey, Action> dsActions = new Dictionary<ConsoleKey, Action>()
        {
            { ConsoleKey.A, GetInstance().AvailableVehicle },
            { ConsoleKey.B, GetInstance().SellCar },
            { ConsoleKey.C, GetInstance().ExecuteVehicleTest }
        };

        #endregion

        #region Singleton Pattern

        private static Dealership _ds;

        public static Dealership GetInstance()
        {
            if (_ds == null) { _ds = new Dealership(); }
            return _ds;
        }

        #endregion

        #region Constructor

        private Dealership()
        {
            _vehicleManager = new VehicleManager();
            _observerManager = new ObserverManager(this);
            _carSeller = new VehicleSeller(this, _vehicleManager);
        }

        #endregion

        #region Menu Methods

        public void DealerShipMenu()
        {
            ConsoleKeyInfo keyPressed;
            do
            {
                Console.WriteLine("A. Car Listing");
                Console.WriteLine("B. Buy Car");
                Console.WriteLine("C. Test Car");
                Console.Write("Please Enter your choice: ");
                keyPressed = Console.ReadKey(false);
                Console.WriteLine("");
                if (dsActions.ContainsKey(keyPressed.Key)) { dsActions[keyPressed.Key](); }
            } while (keyPressed.Key != ConsoleKey.Escape);
        }

        #endregion

        #region Public Methods

        public void SellCar()
        {
            _carSeller.SellVehicle();
        }

        public void AvailableVehicle()
        {
            _vehicleManager.AvailableVehicle();
        }

        public void ExecuteVehicleTest()
        {
            Console.Write("Pick Car to check: ");
            int index = int.Parse(Console.ReadLine());
            AVehicle vehicle = _vehicleManager.GetVehicleByIndex(index - 1);
            vehicle.PerformTest();
        }

        #endregion

        #region ISubject Implementation

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(VehicleBrand vehicleBrand)
        {
            vehicleBrand.Update();
        }

        #endregion
    }
}
