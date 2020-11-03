using System;
using System.Collections.Generic;
using System.Text;
using MilitaryUnitClassLibrary;

namespace MiltaryUnitClassLibrary
{
    public class ExtractionTeam : HazMatResponseUnit
    {
        public int numOfMembers = 4;
        public override string ProtectionLevel()
        {
            return "Level B";
        }
        public override bool DownRange()
        {
            bool downRange = true;
            return downRange;
        }
        public override bool OnAir()
        {
            bool onAir = true;
            return onAir;
        }
        public override string Zones()
        {
            return "Extraction team is in the Hot Zone.";
        }
        public override string Equipment()
        {
            return "The Extract team has the following equipment:\n (1) Plastic litter, (200ft) Rope, (2) Rolls of duct tape,\n (4) Spare SCBA bottles, (3) Detectors,\n " +
                   "(1) Charley cart, (1) Trauma kit, and (1) Radio";
        }
    }
}