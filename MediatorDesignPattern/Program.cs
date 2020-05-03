using System;
using MediatorDesignPattern.Components;
using MediatorDesignPattern.ConcreteMediator;

namespace MediatorDesignPattern
{
    class Program
    {
        //Promena za prvu granu
        static void Main(string[] args)
        {
            ControlTowerMediator controlTower = new ControlTowerMediator();

            PlaneConcrete pc = new PlaneConcrete();
            HelicopterConrete hc = new HelicopterConrete();
            AirplaneConcrete apc = new AirplaneConcrete();

            controlTower.Register(pc);
            controlTower.Register(hc);
            controlTower.Register(apc);

            controlTower.ClearTrack();

            hc.TakeOff();
            Console.WriteLine(hc.GetFlightAltitude());

            apc.TakeOff();
            Console.WriteLine(apc.GetFlightAltitude());

            hc.Land();
            Console.WriteLine(hc.GetFlightAltitude());
            Console.WriteLine(controlTower.GetIsTrackBusy());

            pc.TakeOff();

            Console.WriteLine(pc.GetFlightAltitude());
            
        }
    }
}
