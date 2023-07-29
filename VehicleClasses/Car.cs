namespace CarDealership.VehicleClasses
{
    public class Car : AVehicle
    {

        public Car()
        {
            WheelsAmount = 4;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("This Is Car: ");
            base.DisplayInfo();
        }
        public override void PerformTest()
        {
            Console.WriteLine("---This is car Test---\n");
        }
    }
}
