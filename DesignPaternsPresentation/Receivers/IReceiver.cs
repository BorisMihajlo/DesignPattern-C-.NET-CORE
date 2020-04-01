using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Receivers
{
        public interface IReceiver
    {  
        public void TurnOnOff();
        public bool IncreaseTemperatureBool();
        public bool DecreaseTemperatureBool();
        public bool SetUpAirFlowPositionBool();
        public bool SetDownAirFlowPositionBool();
        public void PrintAllParametars();

    }
}
