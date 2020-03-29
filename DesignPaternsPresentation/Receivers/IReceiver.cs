using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Receivers
{
        public interface IReceiver
    {

        public void TurnOnOff();
        public void IncreaseTemperature();
        public void DecreaseTemperature();

        public void SetUpAirFlowPosition();

        public void SetDownAirFlowPosition();

        public void PrintAllParametars();

    }
}
