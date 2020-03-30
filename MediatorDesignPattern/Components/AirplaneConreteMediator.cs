using MediatorDesignPattern.ConcreteMediator;
using MediatorDesignPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Components
{
    public class AirplaneConcrete : IColleague
    {
        private readonly int id;
        private static float flight_altitude;
        private ControlTowerMediator _ControlTower;

      
        public int GetId()
        {
            return id;
        }
        public AirplaneConcrete()
        {
            Random r = new Random();
            id = r.Next(1, 100);
            _ControlTower = new ControlTowerMediator();
            _ControlTower.Register(this);
        }

        public void Registrer()
        {
            this._ControlTower = new ControlTowerMediator();
        }
        public float GetFlightAltitude()
        {
            return flight_altitude;
        }

        public void TakeOff()
        {
            if (_ControlTower.Getrack() == true)
            {
                _ControlTower.TakeOff(this.id);
                flight_altitude = 8000;
                _ControlTower.ClearTrack();
            }
            else
            {
                _ControlTower.SendMessage();
                flight_altitude = flight_altitude;
            }
        }

        public void Land()
        {
            if (_ControlTower.Getrack() == true)
            {
                _ControlTower.Land(id);
                flight_altitude = 0;
            }
            else
            {
                _ControlTower.SendMessage();
                flight_altitude = flight_altitude;
            }
        }
    }
}

