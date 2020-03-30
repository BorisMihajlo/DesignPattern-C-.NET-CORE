using MediatorDesignPattern.ConcreteMediator;
using MediatorDesignPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Components
{
    public class HelicopterConrete : IColleague
    {
        private readonly int id;
        private static float flight_altitude;
        private ControlTowerMediator ctm;

        public int GetId()
        {
            return id;
        }
        public HelicopterConrete()
        {
            Random r = new Random();
            id = r.Next(1, 100);
            ctm = new ControlTowerMediator();
            ctm.Register(this);

        }
        //public void Registar()
        //{
        //    ctm = new  ControlTowerMediator();
        //    ctm.Register(this);
        //}
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
            {
                ctm.SendMessage();
                flight_altitude = flight_altitude;
            }
        }

        public void Land()
        {
            if (ctm.Getrack() == true)
            {
                ctm.Land(id);
                flight_altitude = 0;
            }
            else
            {
                ctm.SendMessage();
                flight_altitude = flight_altitude;
            }
        }
    }
}
