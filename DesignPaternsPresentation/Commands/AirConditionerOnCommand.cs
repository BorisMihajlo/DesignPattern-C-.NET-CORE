using CommandDesignPatern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Commands
{
    //Vezba za GIT 
    public class AirConditionerOnCommand : ICommand
    {
        private List<IReceiver> acr;
        public AirConditionerOnCommand( List<IReceiver> _acr)
        {
            this.acr = _acr;
        }
        public void execute()
        {
            foreach (var a in acr)
            { 
                a.TurnOnOff();
            }
        }

        public void undo(){}
    }
}
