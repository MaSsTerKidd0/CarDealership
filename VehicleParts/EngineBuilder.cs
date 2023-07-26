using CarDealership.CarBrands;

namespace CarDealership.VehicleParts
{
    public interface IEngineBuilder
    {
        void SetEngineSmk(int smk);
    }
    public class EngineBuilder : IVehiclePartBuilder, IEngineBuilder
    {
        private Engine engine;

        public EngineBuilder()
        {
            Reset();
        }
        #region Builder Setters
        public void Reset()
        {
            engine = new Engine();
        }

        public void SetBrand(AVehicleBrand brand)
        {
            engine.Brand = brand;
        }

        public void SetName(string name)
        {
            engine.Name = name;
        }

        public void SetPrice(int price)
        {
            engine.Price = price;
        }

        public void SetWarranty(int warranty)
        {
            engine.Warranty = warranty;
        }
        public void SetEngineSmk(int smk)
        {
            engine.EngineSmk = smk;
        }

        public Engine GetProduct() { return engine; }
        #endregion
    }
}
