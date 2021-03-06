﻿using CommandDesignPatern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Commands
{
    class AirConditionerTempUpCommand : ICommand
    {
       private List<IReceiver> acr;
        public AirConditionerTempUpCommand(List<IReceiver> _acr)
        {
            this.acr = _acr;
        }
        public void execute()
        {
            foreach (var a in acr)
            {
                a.IncreaseTemperatureBool();
            }
        }

        public void undo()
        {

        }
    }
}
