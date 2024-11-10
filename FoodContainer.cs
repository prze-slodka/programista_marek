using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class FoodContainer : IVisitPort
    {
        public double MaxCapacity { get; set; }

        public double VisitPort()
        {
            double priceTag = (MaxCapacity - GetVolume()) * 5;
            SetVolume(MaxCapacity);
            return priceTag;
        }

        public double GetCapacity() => MaxCapacity;

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

        public FoodContainer(double _capacity)
        {
            MaxCapacity = _capacity;

            _weight = _capacity;
            _volume = _capacity;
        }

        public void SetVolume(double _volume) => Volume = _volume;
        public void SetWeight(double _weight) => Weight = _weight;
    }
}
