using System;
using MediatorDesignPattern.Components;
using MediatorDesignPattern.ConcreteMediator;

namespace MediatorDesignPattern
{
    class Program
    {
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

            apc.TakeOff();
            apc.Land();

            pc.TakeOff();
    
            Console.WriteLine(pc.GetFlightAltitude());
            Console.WriteLine(controlTower.Getrack());
        }
    }
}
