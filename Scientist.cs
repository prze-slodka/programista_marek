using System;

namespace C3
{
    public class Scientist : Human
    {
        private Equipment _equipment;

        public Scientist(Equipment equipment)
        {
            _equipment = equipment;
        }

        public void GatherData()
        {
            // Logic for gathering data
        }

        public void Work(double hours)
        {
            if (hours >= 24)
            {
                GatherData();
            }
        }
    }
}