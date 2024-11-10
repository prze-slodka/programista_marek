using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class FuelTank : IVisitPort
    {
        public double MaxCapacity { get; set; }
        private Fuel Fuel { get; set; }

        private double _weight;
        private double _volume;

        public double Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                if (_volume > 0 && MaxCapacity > 0)
                {
                    _weight = (_volume / MaxCapacity) * MaxCapacity;
                }
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                if (_weight > 0 && MaxCapacity > 0)
                {
                    _volume = (_weight / MaxCapacity) * MaxCapacity;
                }
            }
        }

        public double GetVolume() => Volume;
        public double GetWeight() => Weight;

        public void SetVolume(double _volume) => Volume = _volume;
        public void SetWeight(double _weight) => Weight = _weight;

        public double VisitPort()
        {
            double priceTag = (MaxCapacity - GetVolume()) * 100;
            SetVolume(MaxCapacity);
            return priceTag;
        }

        public FuelTank(double _capacity, Fuel _fuel)
        {
            MaxCapacity = _capacity;
            Fuel = _fuel;

            _weight = _capacity;
            _volume = _capacity;
        }

        public double GetCapacity() => MaxCapacity;

        public string GetFuelType() => Fuel.GetType();
    }
}
