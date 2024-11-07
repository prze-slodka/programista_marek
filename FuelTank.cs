using System;
namespace C3
{
    public class FuelTank : IVisitPort
    {
        private Fuel _fuel;
        public double MaxCapacity { get; }
        public double Volume { get; private set; }
        public double Weight { get; private set; }

        public FuelTank(double capacity, Fuel fuel)
        {
            MaxCapacity = capacity;
            _fuel = fuel;
        }

        public double GetCapacity() => MaxCapacity;
        public string GetFuelType() => _fuel.GetType();

        public void VisitPort()
        {
            Volume = MaxCapacity;
            Weight = Volume * _fuel.Density;
        }
    }
}
