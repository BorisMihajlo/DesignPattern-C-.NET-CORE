using CommandDesignPatern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Commands
{
    class AirConditionerPositionDownCommand :ICommand
    {
        private List<IReceiver> acr;
        public AirConditionerPositionDownCommand(List<IReceiver> _acr)
        {
            this.acr = _acr;
        }
        public void execute()
        {
            foreach (var a in acr)
            {
                a.SetDownAirFlowPosition();
            }
        }

        public void undo()
        {

        }
    }
}
