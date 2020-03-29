using MediatorDesignPattern.ConcreteMediator;
using MediatorDesignPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Components
{
    public class HelicopterConrete : IColleague
    {
        public readonly int id;
        public static float flight_altitude;
        public ControlTowerMediator ctm;

        public int GetId()
        {
            return id;
        }
        public HelicopterConrete(ControlTowerMediator ctm)
        {
            Random r = new Random();
            id = r.Next(1, 100);
            this.ctm = ctm;
        }
        public float GetFlightAltitude()
        {
            return flight_altitude;
        }

        public void FlightOff()
        {
            if (ctm.Getrack() == true)
            {

                ctm.FlightOff(this.id);

                flight_altitude = 4000;
                ctm.ClearTrack();


            }
            else
                ctm.SendMessage();
            flight_altitude = flight_altitude;

        }

        public void Ground()
        {
            if (ctm.Getrack() == true)
            {
                ctm.Ground(id);

                flight_altitude = 0;
            }
            else
                ctm.SendMessage();
            flight_altitude = flight_altitude;


        }

        
    }
}
