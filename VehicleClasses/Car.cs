namespace CarDealership.VehicleClasses
{
    public class Car : AVehicle
    {

        public Car()
        {
            WheelsAmount = 4;
        }

        public override void DisplayVehicleInfo()
        {
            Console.WriteLine("This Is Car: ");
            base.DisplayVehicleInfo();
        }
        public override void PerformTest()
        {
            Console.WriteLine("---This is car Test---\n");
        }
    }
}
