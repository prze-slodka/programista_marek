using System;

namespace C3
{
    public abstract class Fuel
    {
        public abstract string GetType();
        public abstract double Density { get; }
    }

    public class FuelNuclear : Fuel
    {
        public override string GetType() => "nuclear";
        public override double Density => 10; // Example density value
    }

    public class FuelDiesel : Fuel
    {
        public override string GetType() => "diesel";
        public override double Density => 8; // Example density value
    }
}
