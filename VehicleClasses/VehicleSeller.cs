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
            PrintManager.AskVehicleId();
            int vehicleInd = int.Parse(Console.ReadLine() ?? "0");
            AVehicle vehicle = _vehicleManager.GetVehicleByIndex(vehicleInd - 1);
            vehicle.DisplayInfo();
            _vehicleManager.RemoveVehicle(vehicle);
            PrintManager.VehicleSoldMessage();
            vehicle.Brand.CurrentCarsInShop -= 1;
            _subject.Notify(vehicle.Brand);
        }
    }
}
