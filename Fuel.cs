using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    public abstract class Fuel : ITransportable
    {
        public abstract string Type { get; }
        protected abstract double Density { get; }

        public string GetType() => Type;

        public double Weight { get => Volume * Density; set => Volume = value / Density; }
        public double Volume { get; set; }

        public double GetVolume() => Volume;
        public double GetWeight() => Weight;

        public void SetVolume(double _volume) => Volume = _volume;
        public void SetWeight(double _weight) => Weight = _weight;
    }

    public class FuelNuclear : Fuel
    {
        public override string Type => "nuclear";
        protected override double Density => 10;
    }

    public class FuelDiesel : Fuel
    {
        public override string Type => "diesel";
        protected override double Density => 8;
    }
}