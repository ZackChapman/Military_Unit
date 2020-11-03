using System;
using System.Collections.Generic;
using System.Text;
using MilitaryUnitClassLibrary;

namespace MiltaryUnitClassLibrary
{
    public class ReconnaissanceTeam : HazMatResponseUnit
    {
        public int numOfMembers = 4;
        public override string ProtectionLevel()
        {
            return "Level A";
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
            return "Recon team is in the Cold Zone.";
        }
        public override string Equipment()
        {
            return "The Recon team has the following equipment:\n (1) Charley cart, (20) Assorted glow sticks, (10) Numbered cones, (50ft) rope,\n" +
                   "(8) bags spare gloves, (1) Roll of duct tape, (6) Detectors, (1) Clipboard, (4) Sticks of chalk, (1) Radio,\n(1) Video recorder and (4) Markers";
        }
    }
}