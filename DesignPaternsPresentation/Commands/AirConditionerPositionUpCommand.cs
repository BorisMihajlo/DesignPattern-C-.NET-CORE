﻿using CommandDesignPatern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Commands
{
    class AirConditionerPositionUpCommand : ICommand
    {
        private List<IReceiver> acr;
        public AirConditionerPositionUpCommand(List<IReceiver> _acr)
        {
            this.acr = _acr;
        }
        public void execute()
        {
            foreach (var a in acr)
            {
                a.SetUpAirFlowPositionBool();
            }
        }
        public void undo()
        {

        }
    }
}
