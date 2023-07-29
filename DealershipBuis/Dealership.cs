using CarDealership.CarBrands;
using CarDealership.Observer;
using CarDealership.VehicleClasses;
using CarDealership.VehicleParts;
using System.Runtime.CompilerServices;

namespace CarDealership.DealershipBuis
{
    public class Dealership : ISubject
    {
        #region Fields and Properties

        private List<IObserver> _observers = new List<IObserver>();
        private VehicleManager _vehicleManager;
        private ObserverManager _observerManager;
        private VehicleSeller _vehicleSeller;
        private Garage _garage;
        private static Dictionary<ConsoleKey, Action> dsActions = new Dictionary<ConsoleKey, Action>()
        {
            { ConsoleKey.A, GetInstance().AvailableVehicle },
            { ConsoleKey.B, GetInstance().SellCar },
            { ConsoleKey.C, GetInstance().ExecuteVehicleTest },
            { ConsoleKey.D, GetInstance().ExecuteClientVehicleReplaceParts}
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
            _vehicleSeller = new VehicleSeller(this, _vehicleManager);
            _garage = new Garage(_vehicleManager);
        }

        #endregion

        #region Menu Methods

        public void DealerShipMenu()
        {
            ConsoleKeyInfo keyPressed;
            do
            {
                PrintManager.PrintMenu();
                keyPressed = Console.ReadKey(false);
                PrintManager.NewLine();
                if (dsActions.ContainsKey(keyPressed.Key)) { dsActions[keyPressed.Key](); }
            } while (keyPressed.Key != ConsoleKey.Escape);
        }

        #endregion

        #region Public Methods

        public void SellCar()
        {
            _vehicleSeller.SellVehicle();
        }

        public void AvailableVehicle()
        {
            _vehicleManager.AvailableVehicle();
        }

        public void ExecuteVehicleTest()
        {
            PrintManager.CarToCheck();
            int index = int.Parse(Console.ReadLine());
            AVehicle vehicle = _vehicleManager.GetVehicleByIndex(index - 1);
            vehicle.PerformVehicleTest();
        }

        public void ExecuteClientVehicleReplaceParts() 
        {
            _garage.ExecuteClientVehicleReplaceParts();
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

        public void Notify(AVehicleBrand vehicleBrand)
        {
            vehicleBrand.Update();
        }

        #endregion
    }
}
