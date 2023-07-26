using CarDealership.CarBrands;

namespace CarDealership.VehicleClasses
{
    public class VehicleManager
    {
        private List<AVehicle> _vehicles = new List<AVehicle>();
        public AVehicleBrand[] workingWithBrands = new AVehicleBrand[] { new Toyota(), new Honda(), new Ford(), new BMW() };

        public VehicleManager()
        {
            InitList();
        }

        private void InitList()
        {
            Random rnd = new Random();
            for (int i = 0; i < workingWithBrands.Length; i++)
            {
                _vehicles.AddRange(workingWithBrands[i].CarProducer(rnd.Next(3, 5)));
            }
        }


        public void AddVehicle(AVehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public void RemoveVehicle(AVehicle vehicle)
        {
            _vehicles.Remove(vehicle);
        }

        public AVehicle GetVehicleByIndex(int index)
        {
            if (index >= 0 && index < _vehicles.Count)
            {
                return _vehicles[index];
            }
            return null;
        }

        public void AvailableVehicle()
        {
            int counter = 1;
            if (_vehicles.Count == 0)
            {
                Console.WriteLine("No cars available in the dealership.");
                return;
            }

            Console.WriteLine("Available cars in the dealership:");
            foreach (var vehicle in _vehicles)
            {
                Console.Write($"{counter++}.");
                vehicle.DisplayVehicleInfo();
            }
        }
    }
}
