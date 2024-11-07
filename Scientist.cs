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
            _equipment.CollectData(); // Example method to collect data using equipment
            Console.WriteLine("Data gathered successfully.");
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