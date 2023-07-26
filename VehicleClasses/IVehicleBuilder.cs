using CarDealership.CarBrands;
using CarDealership.CarTests;
using CarDealership.VehicleParts;

namespace CarDealership.VehicleClasses
{
    public interface IVehicleBuilder
    {
        void Reset();
        void SetYear(int year);
        void SetSeatingCapacity(int seatingCapacity);
        void SetHorsePower(int horsePower);
        void SetPrice(int price);
        void SetBrand(AVehicleBrand brand);
        void SetModel(string model);
        void SetType(string typ);
        void SetTest(ITest test);
        void SetEngine(Engine en);
        void SetBattery(Battery battery);
    }
}
