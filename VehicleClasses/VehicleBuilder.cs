using CarDealership.CarBrands;
using CarDealership.CarTests;

namespace CarDealership.VehicleClasses
{
    public interface VehicleBuilder
    {
        void Reset();
        void SetYear(int year);
        void SetSeatingCapacity(int seatingCapacity);
        void SetHorsePower(int horsePower);
        void SetPrice(int price);
        void SetBrand(VehicleBrand brand);
        void SetModel(string model);
        void SetType(string typ);
        void SetTest(ITest test);
    }
}
