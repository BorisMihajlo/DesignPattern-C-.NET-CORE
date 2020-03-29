using System;
using MediatorDesignPattern.Components;
using MediatorDesignPattern.ConcreteMediator;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTowerMediator ctm = new ControlTowerMediator();

            PlaneConcrete pc = new PlaneConcrete(ctm);
            HelicopterConrete hc = new HelicopterConrete(ctm);
            AirplaneConcrete apc = new AirplaneConcrete(ctm);

            ctm.colleague.Add(pc);
            ctm.colleague.Add(apc);
            ctm.colleague.Add(hc);


            ctm.ClearTrack();

            Console.WriteLine(pc.GetFlightAltitude());
            Console.WriteLine(apc.GetFlightAltitude());
            Console.WriteLine(hc.GetFlightAltitude());

            Console.WriteLine(ctm.Getrack());

            pc.FlightOff();
            apc.FlightOff();


            Console.WriteLine(pc.GetFlightAltitude());
            Console.WriteLine(apc.GetFlightAltitude());

            Console.WriteLine(ctm.Getrack());

            pc.Ground();
            Console.WriteLine(pc.GetFlightAltitude());

            hc.FlightOff();
            Console.WriteLine(hc.GetFlightAltitude());
            Console.WriteLine(ctm.Getrack());


        }
    }
}
