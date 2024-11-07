using System;

namespace C3
{
    public class LifeSupportSystem
    {
        public class LifeSupportSystem
        {
            public List<OxygenBottle> oxygenBottles { get; set; }
            public FoodContainer foodContainer { get; set; }
            public Waste waste { get; set; }
            public List<Crewman> crew { get; set; }

            public void CheckSuppliesBeforeTravel()
            {
                foreach (var oxygenBottle in oxygenBottles)
                {
                    if (oxygenBottle.Volume < oxygenBottle.MaxCapacity)
                    {
                        throw new Exception("Oxygen supplies are insufficient for travel.");
                    }
                }

                if (foodContainer.Volume < foodContainer.MaxCapacity)
                {
                    throw new Exception("Food supplies are insufficient for travel.");
                }

                if (waste.Volume > 0)
                {
                    throw new Exception("Waste needs to be disposed of before travel.");
                }
            }

            public void Run()
            {
                CheckSuppliesBeforeTravel();

                foreach (var oxygenBottle in oxygenBottles)
                {
                    oxygenBottle.Volume -= 1; // Example consumption rate
                    oxygenBottle.Weight = oxygenBottle.Volume * 1.429; // Update weight based on volume
                }

                foodContainer.Volume -= crew.Count; // Example consumption rate per crew member
                foodContainer.Weight = foodContainer.Volume * 0.8; // Update weight based on volume

                waste.Volume += crew.Count; // Example waste production rate per crew member
            }
        }
    }
}
}
