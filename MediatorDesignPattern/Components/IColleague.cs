using MediatorDesignPattern.ConcreteMediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Components
{
   public abstract class BaseColleague
    {
        public abstract Guid GetId();
        public abstract void TakeOff();
        public abstract void Land();

        public ControlTowerMediator ControlTower;

    }
}
