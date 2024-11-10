using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    public abstract class Human : ITransportable
    {
        private double _weight;
        private double _volume;
        private const double Density = 0.8; // Hypothetical density factor (weight per volume)

        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                _volume = _weight / Density; // Update volume based on weight
            }
        }

        public double Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                _weight = _volume * Density; // Update weight based on volume
            }
        }

        public double GetVolume() => Volume;
        public double GetWeight() => Weight;

        public void SetVolume(double _volume) => Volume = _volume;
        public void SetWeight(double _weight) => Weight = _weight;
    }
}