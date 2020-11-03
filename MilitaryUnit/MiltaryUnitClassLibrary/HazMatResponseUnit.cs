using MiltaryUnitClassLibrary;
using System;

namespace MilitaryUnitClassLibrary
{
    public class HazMatResponseUnit //Base Class the Unit
    {
        public string Mission ="Hazmat Response";
        public string Type = "Clandestine Lab";

        public string Perimeter()
        {
            return "The safety perimeter of 250 ft has been established in accordance with the ERG 2019.";
        }
        public bool Comms = true;
        public bool Vitals = true;
        public virtual bool OnAir()
        {
            bool onAir = true;
            return onAir;
        }

        public virtual bool DownRange()
        {
            bool downRange = true;
            return downRange;
        }

        public virtual string ProtectionLevel()
        {
            return "Level A";
        }

        public virtual string Zones()
        {
            return  "The Cold, Warm, and Hot zones established.";
        }
        public virtual string Equipment()
        {
            return "The Hazmat Response Unit has all the equipment required for the " + Mission + " to the " + Type;
        }
    }
}
