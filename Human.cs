namespace C3
{
    public abstract class Human : ITransportable
    {
        public double Weight { get; set; }
        public double Volume { get; set; }

        public Human(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }

        public double GetWeight() => Weight;
        public double GetVolume() => Volume;
    }
}
