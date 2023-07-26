namespace CarDealership.CarTests
{
    public class BMWTest : VehicleTest
    {
        public override void PerformAirPollutionTest()
        {
            Console.Write("BMW Test->");
            base.PerformAirPollutionTest();
        }

        public override void PerformDriveTest()
        {
            Console.Write("BMW Test->");
            base.PerformDriveTest();
        }

        public override void PerformEngineTest()
        {
            Console.Write("BMW Test->");
            base.PerformEngineTest();
        }
    }
}
