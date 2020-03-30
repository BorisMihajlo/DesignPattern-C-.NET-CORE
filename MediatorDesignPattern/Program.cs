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

            pc.TakeOff();
            apc.TakeOff();


            Console.WriteLine(pc.GetFlightAltitude());
            Console.WriteLine(apc.GetFlightAltitude());

            Console.WriteLine(ctm.Getrack());

            pc.Land();
            Console.WriteLine(pc.GetFlightAltitude());

            hc.TakeOff();
            Console.WriteLine(hc.GetFlightAltitude());
            Console.WriteLine(ctm.Getrack());

            ctm.ClearTrack();

            hc.TakeOff();
            Console.WriteLine(hc.GetFlightAltitude());
            Console.WriteLine(ctm.Getrack());

        }
    }
}
