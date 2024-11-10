using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste { get; set; }

        public Engine(FuelTank _tank, Waste _waste) 
        {
            tank = _tank;
            waste = _waste;
        }

        public double GetVelocity(double submarineWeight)
        {
            return 150000 / submarineWeight;
        }

        public bool CheckFuelBeforeTravel(double travelTime)
        {
            return tank.GetVolume() > travelTime * 0.1;
        }

        public void Travel(double travelTime)
        {
            tank.SetVolume(travelTime * 0.1);
            waste.SetVolume(waste.GetVolume() + (travelTime * 0.1 * 0.05));
        }
    }
}
