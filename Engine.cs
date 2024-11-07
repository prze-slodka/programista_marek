using System;
namespace C3
{
    public class Engine
    {
        private double _speed;
        private double _totalWeight;

        public void CheckFuelBeforeTravel(FuelTank fuelTank)
        {
            if (fuelTank.Volume <= 0)
            {
                throw new Exception("Insufficient fuel for travel.");
            }
        }

        public void Travel(FuelTank fuelTank)
        {
            CheckFuelBeforeTravel(fuelTank);

            // Example logic for fuel consumption and waste production
            double fuelConsumption = 10; // Example fuel consumption rate
            fuelTank.Volume -= fuelConsumption;

            if (fuelTank.Volume < 0)
            {
                fuelTank.Volume = 0;
            }

            waste.Volume += fuelConsumption; // Update waste production
        }

        public void AdjustSpeed(double weight)
        {
            _totalWeight = weight;
            _speed = 100 / _totalWeight; // Example speed calculation
        }
    }

}
