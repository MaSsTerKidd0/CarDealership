using CarDealership.CarBrands;

namespace CarDealership.VehicleParts
{
    public interface IBatteryBuilder
    {
        void SetVoltage(int voltage);
    }

    public class BatteryBuilder : IVehiclePartBuilder, IBatteryBuilder
    {
        private Battery battery;

        public BatteryBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            battery = new Battery();
        }

        public void SetBrand(AVehicleBrand brand)
        {
            battery.Brand = brand;
        }

        public void SetName(string name)
        {
            battery.Name = name;
        }

        public void SetPrice(int price)
        {
            battery.Price = price;
        }

        public void SetWarranty(int warranty)
        {
            battery.Warranty = warranty;
        }
        public void SetVoltage(int voltage)
        {
            battery.Voltage = voltage;
        }
        public Battery GetProduct() { return battery; }
    }
}
