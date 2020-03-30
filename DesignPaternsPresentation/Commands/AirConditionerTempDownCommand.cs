using CommandDesignPatern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Commands
{
    class AirConditionerTempDownCommand : ICommand
    {
        public List<IReceiver> acr;
        public AirConditionerTempDownCommand(List<IReceiver> _acr)
        {
            this.acr = _acr;
        }
        public void execute()
        {
            foreach (var a in acr)
            {
                a.DecreaseTemperature();
            }
        }

        public void undo()
        {

        }
    }
}
