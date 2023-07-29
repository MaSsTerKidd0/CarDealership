namespace CarDealership.VehicleClasses
{
    public class Motorcycle : AVehicle
    {
        public Motorcycle()
        {
            WheelsAmount = 2;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("This Is MotorCycle: ");
            base.DisplayInfo();
        }
        public override void PerformTest()
        {
            Console.WriteLine("---This is Motorcycle Test---\n");
        }
    }
}
