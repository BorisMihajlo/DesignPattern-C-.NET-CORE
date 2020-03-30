using MediatorDesignPattern.ConcreteMediator;
using MediatorDesignPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Components
{
   public class PlaneConcrete : IColleague
    {
        public readonly int id;
        public static float flight_altitude;
        public ControlTowerMediator ctm;

        public int GetId()
        {
            return id;
        }
        public PlaneConcrete(ControlTowerMediator ctm)
        {
            Random r = new Random();
            id = r.Next(1, 100);
            this.ctm = ctm;
        }
        public float GetFlightAltitude()
        {
            return flight_altitude;
        }
       
        public void TakeOff()
        {
            if (ctm.Getrack() == true)
            {
               
                ctm.TakeOff(this.id);
                
                flight_altitude = 4000;
                ctm.ClearTrack();
                
                
            }
            else
                ctm.SendMessage();
            flight_altitude = flight_altitude;


        }

        public void Land()
        {
            if (ctm.Getrack() == true)
            {
                ctm.Land(id);

                flight_altitude = 0;
            }
            else
                ctm.SendMessage();
            flight_altitude = flight_altitude;


        }

       
    }
}
