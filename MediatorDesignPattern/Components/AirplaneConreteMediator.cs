using MediatorDesignPattern.ConcreteMediator;
using MediatorDesignPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Components
{
    public class AirplaneConcrete : BaseColleague
    {
        private readonly Guid id;
        private static float flight_altitude;
        


        public override Guid GetId()
        {
            return id;
        }
        public AirplaneConcrete()  
        {
            id = Guid.NewGuid();      
        }

        public float GetFlightAltitude()
        {
            return flight_altitude;
        }

        public override void TakeOff()
        {
            if (ControlTower.GetIsTrackBusy() == true)
            {
                ControlTower.TakeOff(this.id);
                flight_altitude = 8000;
                ControlTower.ClearTrack();
            }
            else
            {
                ControlTower.SendMessage();
                flight_altitude = flight_altitude;
            }
        }

        public override void Land()
        {
            if (ControlTower.GetIsTrackBusy() == true)
            {
                ControlTower.Land(id);
                flight_altitude = 0;
            }
            else
            {
                ControlTower.SendMessage();
                flight_altitude = flight_altitude;
            }
        }
    }
}

