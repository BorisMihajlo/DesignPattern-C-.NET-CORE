using MediatorDesignPattern.Components;
using MediatorDesignPattern.ConcreteMediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Mediator
{
    public interface IMediator
    {   public void TakeOff(int i);
        public void Land(int i);
    }
}
