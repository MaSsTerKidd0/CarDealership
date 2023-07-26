using CarDealership.CarBrands;
using CarDealership.Observer;

namespace CarDealership.DealershipBuis
{
    public class ObserverManager
    {
        private AVehicleBrand[] workingWithBrands;
        private ISubject _subject;

        public ObserverManager(ISubject subject)
        {
            _subject = subject;
            workingWithBrands = new AVehicleBrand[] { new Toyota(), new Honda(), new Ford(), new BMW() };
            RegisterObservers();
        }

        private void RegisterObservers()
        {
            foreach (var brand in workingWithBrands)
            {
                _subject.Attach(brand);
            }
        }
    }
}
