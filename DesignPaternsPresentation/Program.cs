using CommandDesignPatern.Commands;
using CommandDesignPatern.Invokers;
using CommandDesignPatern.Receivers;
using System;
using System.Collections.Generic;

namespace DesignPaternsPresentation
{
    class Program
    {
      
        static void Main(string[] args)
        {
           List<IReceiver> receivers = new List<IReceiver>();
            
           AirConditionerReceiver acr = new AirConditionerReceiver();
           AirConditionerReceiverPhilips acrPhilips = new AirConditionerReceiverPhilips();

            //Add to List of receivers
            receivers.Add(acr);
            receivers.Add(acrPhilips);

            // Commands for Remoter
           AirConditionerOnCommand onoff= new AirConditionerOnCommand(receivers);
           AirConditionerPositionDownCommand airdown = new AirConditionerPositionDownCommand(receivers);
           AirConditionerPositionUpCommand airup = new AirConditionerPositionUpCommand(receivers);
           AirConditionerTempDownCommand tempdown = new AirConditionerTempDownCommand(receivers);
           AirConditionerTempUpCommand tempup = new AirConditionerTempUpCommand(receivers);

            
           Remoter r1 = new Remoter(onoff,tempup,tempdown,airup,airdown);


            r1.ClickOnOffButton();
            r1.ClickPositionDown();
            


            foreach (var a in receivers)
                a.PrintAllParametars();

















        }
    }
}
