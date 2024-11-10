using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Equipment : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0;
            }
        }

        public double GetVolume() => Volume;
        public double GetWeight() => Weight;

        public void SetVolume(double _volume)
        {
            Volume = _volume;
        }

        public void SetWeight(double _weight)
        {
            Weight = _weight;
        }
		
        public string GatherData()
        {
            string ans = "";
            for (int i = 0; i < 10; i++) ans += (char)(new Random()).Next(128);
            return "Important data gathered: " + ans;
        }
    }
}
