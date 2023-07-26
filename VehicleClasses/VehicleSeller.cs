using CarDealership.Observer;

namespace CarDealership.VehicleClasses
{
    public class VehicleSeller
    {
        private ISubject _subject;
        private VehicleManager _vehicleManager;

        public VehicleSeller(ISubject subject, VehicleManager vehicleManager)
        {
            _subject = subject;
            _vehicleManager = vehicleManager;
        }

        public void SellVehicle()
        {
            Console.WriteLine("Enter The CarInd: ");
            int vehicleInd = int.Parse(Console.ReadLine() ?? "0");
            AVehicle vehicle = _vehicleManager.GetVehicleByIndex(vehicleInd - 1);
            vehicle.DisplayVehicleInfo();
            _vehicleManager.RemoveVehicle(vehicle);
            Console.WriteLine("\n--Car Sold--");
            vehicle.Brand.CurrentCarsInShop -= 1;
            _subject.Notify(vehicle.Brand);
        }
    }
}
