using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Scientist : Human
    {
        private Equipment equipment;

        public Scientist(Equipment _equipment)
        {
            equipment = _equipment;
        }

        public void Work(double time)
        {
            Console.WriteLine($"Scientist worked for {Math.Round(time, 2)}h");
            if (time >= 24)
            {
                Console.WriteLine(equipment.GatherData());
            }
        }
    }
}
