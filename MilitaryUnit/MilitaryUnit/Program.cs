using MiltaryUnitClassLibrary;
using System;
using MilitaryUnitClassLibrary;

namespace MilitaryUnit
{
    class Program
    {

        static void Main(string[] args)
        {
            HazMatResponseUnit hazMatResponseUnit = new HazMatResponseUnit();
            DecontaminationTeam decontaminationTeam = new DecontaminationTeam();
            ReconnaissanceTeam reconnaissanceTeam = new ReconnaissanceTeam();
            ExtractionTeam extractionTeam = new ExtractionTeam();
            SamplingTeam samplingTeam = new SamplingTeam();
            IncidentComander incidentComander = new IncidentComander();

            Console.WriteLine($"The Hazardous Response Team! \n{hazMatResponseUnit.Equipment()}\nHas Comms? {hazMatResponseUnit.Comms}" +
                              $"\n{hazMatResponseUnit.Perimeter()}\ncompleted vitals {hazMatResponseUnit.Vitals} \nDown range? {hazMatResponseUnit.DownRange()}" +
                              $"\n{hazMatResponseUnit.ProtectionLevel()} \nUsing supplied air? {hazMatResponseUnit.OnAir()} \n{hazMatResponseUnit.Zones()}");
            Console.WriteLine("__________________________________________________________________________________________");

            Console.WriteLine($"The decontamination team! \n{decontaminationTeam.Equipment()}\nIs established{decontaminationTeam.Established} \nHas Comms? {decontaminationTeam.Comms}" +
                              $"\nHas {decontaminationTeam.numOfMembers}members \nCompleted vitals {decontaminationTeam.Vitals} \nDown range? {decontaminationTeam.DownRange()}" +
                              $"\n{decontaminationTeam.ProtectionLevel()} \nUsing supplied air? {decontaminationTeam.OnAir()} \n{decontaminationTeam.Zones()}");
            Console.WriteLine("__________________________________________________________________________________________");

            Console.WriteLine($"The reconnaissance team! \n{reconnaissanceTeam.Equipment()}\nHas Comms {reconnaissanceTeam.Comms}" +
                              $"\nHas {reconnaissanceTeam.numOfMembers}members \nCompleted vitals {reconnaissanceTeam.Vitals} \nDown range? {reconnaissanceTeam.DownRange()}" +
                              $"\n{reconnaissanceTeam.ProtectionLevel()} \nUsing supplied air? {reconnaissanceTeam.OnAir()} \n{reconnaissanceTeam.Zones()}");
            Console.WriteLine("__________________________________________________________________________________________");

            Console.WriteLine($"The extraction team! \n{extractionTeam.Equipment()}\nHas Comms {extractionTeam.Comms}" +
                              $"\nHas {extractionTeam.numOfMembers}members \nCompleted vitals {extractionTeam.Vitals} \nDown range? {extractionTeam.DownRange()}" +
                              $"\n{extractionTeam.ProtectionLevel()} \nUsing supplied air? {extractionTeam.OnAir()} \n{extractionTeam.Zones()}");
            Console.WriteLine("__________________________________________________________________________________________");

            Console.WriteLine($"The sampling team! \n{samplingTeam.Equipment()} \nHas Comms {samplingTeam.Comms}" +
                              $"\nHas {samplingTeam.numOfMembers}members \nCompleted vitals {samplingTeam.Vitals} \nDown range? {samplingTeam.DownRange()}" +
                              $"\n{samplingTeam.ProtectionLevel()} \nUsing supplied air? {samplingTeam.OnAir()} \n{samplingTeam.Zones()}");
            Console.WriteLine("__________________________________________________________________________________________");

            Console.WriteLine($"The Incident Commander team! \n{incidentComander.Equipment()}\nHas Comms {incidentComander.Comms}" +
                              $"\nHas {incidentComander.numOfMembers}members \nCompleted vitals {incidentComander.Vitals} \nDown range? {incidentComander.DownRange()}" +
                              $"\n{incidentComander.ProtectionLevel()} \nUsing supplied air? {incidentComander.OnAir()} \n{incidentComander.Zones()}");
            Console.WriteLine("__________________________________________________________________________________________");


            Console.ReadLine();
        }
    }
}

