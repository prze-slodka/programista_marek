using System;

namespace C3
{
    public class LifeSupportSystem
    {
        public List<OxygenBottle> oxygenBottles { get; set; }
        public FoodContainer foodContainer { get; set; }
        public Waste waste { get; set; }
        public List<Crewman> crew { get; set; }

        public void CheckSuppliesBeforeTravel()
        {
            // Logic to check resources before travel
        }

        public void Run()
        {
            CheckSuppliesBeforeTravel();
            // Logic to consume resources during travel
        }
    }
}
