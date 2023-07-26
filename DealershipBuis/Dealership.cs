using CarDealership.CarBrands;
using CarDealership.Observer;
using CarDealership.VehicleClasses;
using CarDealership.VehicleParts;

namespace CarDealership.DealershipBuis
{
    public class Dealership : ISubject
    {
        #region Fields and Properties

        private List<IObserver> _observers = new List<IObserver>();
        private VehicleManager _vehicleManager;
        private ObserverManager _observerManager;
        private VehicleSeller _vehicleSeller;
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
                Console.WriteLine("D. Repalce Car Part");
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
            _vehicleSeller.SellVehicle();
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
            vehicle.PerformVehicleTest();
        }

        public void ExecuteClientVehicleReplaceParts()
        {
            //TODO: DON'T Like hard coded need to split
            int choice, index;
            Random rand = new Random();
            List<AVehiclePart> repParts = new List<AVehiclePart>();
            CarBuilder builder = new CarBuilder();
            _vehicleManager.workingWithBrands[rand.Next(0, 3)].BuildVehicle(builder);
            AVehicle v = builder.GetProduct();
            Console.WriteLine("\nClient Car-> ");
            v.DisplayVehicleInfo();
            Console.WriteLine("Change: \n1.Engine\n2.Battery\n Pick:");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < _vehicleManager.workingWithBrands.Length; i++)
                {
                    repParts.AddRange(_vehicleManager.workingWithBrands[i].GetBrandParts("Engines"));
                }
            }
            else
            {
                for (int i = 0; i < _vehicleManager.workingWithBrands.Length; i++)
                {
                    repParts.AddRange(_vehicleManager.workingWithBrands[i].GetBrandParts("Batterys"));
                }
            }
            for (int i = 0; i < repParts.Count; i++)
            {
                Console.WriteLine($"{i+1}. {repParts[i].Name}");
            }
            Console.WriteLine("Please Choose replacement: ");
            index = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                v.VehicleEngine = (Engine)repParts[index -1];
            }
            else
            {
                v.VehicleBattery = (Battery)repParts[index -1];
            }

            Console.WriteLine("Client Car After Change: ");
            v.DisplayVehicleInfo();
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
