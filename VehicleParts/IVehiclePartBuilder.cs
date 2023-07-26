using CarDealership.CarBrands;

namespace CarDealership.VehicleParts
{
    public interface IVehiclePartBuilder
    {
        void Reset();
        void SetPrice(int price);
        void SetName(string name);
        void SetBrand(AVehicleBrand brand);
        void SetWarranty(int warranty);
    }
}
