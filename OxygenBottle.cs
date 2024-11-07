using System;
namespace C3
{
    public class OxygenBottle : ITransportable, IVisitPort
    {
        public double MaxCapacity { get; set; }
        public double Volume { get; set; }
        public double Weight { get; set; }

        public void VisitPort()
        {
            Volume = MaxCapacity;
            Weight = Volume * 1.429; // Example density for oxygen
        }
    }
}

