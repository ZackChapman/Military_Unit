using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using MilitaryUnitClassLibrary;

namespace MiltaryUnitClassLibrary
{
    public class SamplingTeam :HazMatResponseUnit
    {
        public int numOfMembers = 3;
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
        public override string ProtectionLevel()
        {
            return "Level B";
        }
        public override string Zones()
        {
            return "Sampling team is in the Hot Zone.";
        }
        public override string Equipment()
        {
            return "The Sampling team has the following equipment:\n (1) Charley cart, (1) Quicksilver Kit, (1) Video Recorder, (1) Camera,\n" +
                   "(1) Large trash bag, (1) Roll of Duct tape, (6) Detectors, (1) Temp gun, (2) Pens, (1) Radio, and (4) Markers";
        }
    }

}