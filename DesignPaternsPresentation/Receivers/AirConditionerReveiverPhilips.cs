using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Receivers
{
    public class AirConditionerReceiverPhilips : IReceiver
    {
        public static bool OnOff=true;
        public static int temperature = 20;
        public static int airFlowPosition = 2;
        public bool executed;



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

        public void IncreaseTemperature()
        {
            if (OnOff == true && temperature < 31)
                temperature++;
        }

        public void DecreaseTemperature()
        {
            if (OnOff == true && temperature > 14)
                temperature--;
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
            if (OnOff == true && airFlowPosition >0 && airFlowPosition <= 4)
            {
                airFlowPosition--;
                return true;
            }
           else return false;

            

        }

        public void SetDownAirFlowPosition()
        {
            if (OnOff == true && airFlowPosition > 0 && airFlowPosition <= 4)
            {
                airFlowPosition--;
               
            }
           

        }

        public void SetUpAirFlowPosition()
        {
            if (OnOff == true && airFlowPosition >= 0 && airFlowPosition < 4)
            {
                airFlowPosition++;

            }


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
