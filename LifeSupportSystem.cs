using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;

        public LifeSupportSystem(List<OxygenBottle> _bottles, FoodContainer _container, Waste _waste, List<Human> _crew)
        {
            oxygenBottles = _bottles;
            foodContainer = _container;
            waste = _waste;
            crew = _crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            if (travelTime > 100) return false;

            foreach (var bottle in oxygenBottles)
            {
                if (bottle.GetVolume() < 0.8 * bottle.MaxCapacity)
                {
                    return false;
                }
            }

            if (waste.GetVolume() > 1) return false;

            if (foodContainer.GetVolume() == 0) return false;

            return true;
        }

        public void Run(double travelTime)
        {
            double usedFood = travelTime * 0.1 * crew.Count;

            foodContainer.SetVolume(foodContainer.GetVolume() - usedFood);
            waste.SetVolume(waste.GetVolume() + (usedFood * 0.01));

            foreach (var bottle in oxygenBottles)
            {
                bottle.SetVolume(bottle.GetVolume() - (travelTime * crew.Count));
            }
        }
    }
}
