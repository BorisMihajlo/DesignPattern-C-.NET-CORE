using MediatorDesignPattern.Components;
using MediatorDesignPattern.ConcreteMediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Mediator
{
    public interface IMediator
    {
        public void FlightOff(int i);
       // public void Ground(int i);
    }
}
