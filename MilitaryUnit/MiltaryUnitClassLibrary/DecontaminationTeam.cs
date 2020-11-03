using System;
using System.Collections.Generic;
using System.Text;
using MilitaryUnitClassLibrary;

namespace MiltaryUnitClassLibrary
{
    public class DecontaminationTeam : HazMatResponseUnit
    {
        
        public int numOfMembers = 6;
        public bool Established = true;
        public override bool DownRange()
        {
            bool downRange = false;
            return downRange;
        }


        public override string Equipment()
        {
            return "The Decon team has the following equipment:\n(1) Fire hose, (4) 50 gal drums, (8) Long handle brushes, (200ft) Engineers tape,\n" +
                   "(3) Large Basins, (1) Box RSDL, (6) Detectors, (1) Tent, (1) Large ice chest, (1) Radio, and (4) Chairs";
        }

        public override string ProtectionLevel()
        {
            return "Level C";
        }
        public override bool OnAir()
        {
            bool onAir = false;
            return onAir;
        }
        public override string Zones()
        {
            return "Decon team is in the Warm Zone.";
        }

    }
}