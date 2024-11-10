using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Waste : IVisitPort
    {
        public double VisitPort()
        {
            double priceTag = GetVolume() * 7.5;
            SetVolume(0);
            return priceTag;
        }

        private double _weight;
        private double _volume;
        private const double Density = 0.5;

        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                _volume = _weight / Density;
            }
        }

        public double Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                _weight = _volume * Density;
            }
        }

        public double GetVolume() => Volume;
        public double GetWeight() => Weight;

        public void SetVolume(double _volume) => Volume = _volume;
        public void SetWeight(double _weight) => Weight = _weight;
    }
}
