using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Receivers
{
    public class AirConditionerReceiverPhilips : IReceiver
    {
        private static bool OnOff=true;
        private static int temperature = 20;
        private static int airFlowPosition = 2;
       

        public AirConditionerReceiverPhilips() { }
        public bool IncreaseTemperatureBool()
        {
            if (OnOff == true && temperature < 31)
            {
                temperature++;
                return true;
            }
            else return false;
        }

        public bool DecreaseTemperatureBool()
        {
            if (OnOff == true && temperature > 14)
            {
                temperature--;
                return true;
            }
            return false;
        }

        public bool SetUpAirFlowPositionBool()
        {

            if (OnOff == true && airFlowPosition >= 0 && airFlowPosition < 4)
            {
                airFlowPosition++;
                return true;
            }
            else
                return false;
        }
        public bool SetDownAirFlowPositionBool()
        {
            if (OnOff == true && airFlowPosition > 0 && airFlowPosition <= 4)
            {
                airFlowPosition--;
                return true;
            }
            else return false;
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
