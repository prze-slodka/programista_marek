using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Crewman : Human
    {
        public string Duty { get; set; }

        public Crewman()
        {
            Duty = "Worker";
        }

        public Crewman(string duty = "Worker")
        {
            Duty = duty;
        }
    }
}