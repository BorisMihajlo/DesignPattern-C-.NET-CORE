using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Receivers
{
    public class AirConditionerReceiverPhilips : IReceiver
    {
        public static bool OnOff;
        public static int temperature = 29;
        public static int airFlowPosition = 2;



        public AirConditionerReceiverPhilips() { }
        public void IncreaseTemperature()
        {
            if (OnOff == true && temperature < 31)
                temperature++;
        }

        public void DecreaseTemperature()
        {
            if (OnOff == true && temperature >14)
                temperature--;
        }
        public void SetUpAirFlowPosition()
        {

            if (OnOff == true && airFlowPosition >= 0 && airFlowPosition < 4)
                airFlowPosition++;
        }
        public void SetDownAirFlowPosition()
        {
            if (OnOff == true && airFlowPosition > 0 && airFlowPosition <= 4)
                airFlowPosition--;
        }

        public void TurnOnOff()
        {
            if (OnOff == false)
            {
                OnOff = true;
            }

            else if (OnOff == true)
            {
                OnOff = false;
            }
        }
        public void PrintAllParametars()
        {
            if (OnOff == true)
                Console.WriteLine("Temperature= " + temperature + "   " + "Air Flow Position = " + airFlowPosition);
        }
    }
}
