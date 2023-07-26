using CarDealership.CarBrands;

namespace CarDealership.Observer
{
    public interface IObserver
    {
        void Update();
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(AVehicleBrand vehiclebrand);
    }
}
