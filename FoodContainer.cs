using System;
namespace C3
{
    public class FoodContainer : ITransportable, IVisitPort
    {
        public double MaxCapacity { get; set; }
        public double Volume { get; set; }
        public double Weight { get; set; }

        public void VisitPort()
        {
            Volume = MaxCapacity;
            Weight = Volume * 0.8; // Example density for food
        }
    }
}

