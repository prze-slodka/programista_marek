using System;
namespace C3
{
    public class Waste : ITransportable, IVisitPort
    {
        public double Volume { get; set; }
        public double Weight { get; set; }

        public void VisitPort()
        {
            Volume = 0;
        }
    }

}

