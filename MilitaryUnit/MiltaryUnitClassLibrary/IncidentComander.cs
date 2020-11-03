using System;
using System.Collections.Generic;
using System.Text;
using MilitaryUnitClassLibrary;

namespace MiltaryUnitClassLibrary
{
    public class IncidentComander : HazMatResponseUnit
    {
        public int numOfMembers = 6;
        public override string ProtectionLevel()
        {
            return "Level D";
        }
        public override bool DownRange()
        {
            bool downRange = false;
            return downRange;
        }
        public override bool OnAir()
        {
            bool onAir = false;
            return onAir;
        }
        public override string Zones()
        {
            return "IC team is in the Cold Zone.";
        }
        public override string Equipment()
        {
            return "The IC team has the following equipment:\n (2) Desks, (2) ERGs, (2) NIOSHs, (1) HAZMAT ID,\n" +
                   "(3) SPEIME, (1) Box writing utensils,(6) Publication binders, (1) Tent, (1) Large ice chest, (3) Radios, and (6) Chairs";
        }
    }
}