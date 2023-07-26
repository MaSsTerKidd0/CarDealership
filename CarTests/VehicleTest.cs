namespace CarDealership.CarTests
{
    public class VehicleTest : ITest
    {
        public virtual void PerformEngineTest()
        {
            Console.WriteLine("Performing Engine Test...");
        }

        public virtual void PerformAirPollutionTest()
        {
            Console.WriteLine("Performing Air Pollution Test...");
        }
        public virtual void PerformDriveTest()
        {
            Console.WriteLine("Performing Drive Test...");
        }

    }
}
