﻿using CommandDesignPatern;
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


            var commands = new List<ICommand>()
            {
                new RemoterCommand(receivers, RemoterCommand.Action.TempUp),
                new RemoterCommand(receivers, RemoterCommand.Action.TempUp),
                new RemoterCommand(receivers, RemoterCommand.Action.TempUp),
                new RemoterCommand(receivers, RemoterCommand.Action.PositionUp),
                new RemoterCommand(receivers, RemoterCommand.Action.PositionUp),
                new RemoterCommand(receivers, RemoterCommand.Action.PositionUp),
                 new RemoterCommand(receivers, RemoterCommand.Action.PositionDown),

            };


            foreach (var command in commands)
            {
                command.execute();
            }

            foreach (var command in commands)
            {
                command.undo();
            }


            foreach (var a in receivers)
                a.PrintAllParametars();





            //  Commands for Remoter

            // AirConditionerOnCommand onoff = new AirConditionerOnCommand(receivers);
            // AirConditionerPositionDownCommand airdown = new AirConditionerPositionDownCommand(receivers);
            //AirConditionerPositionUpCommand airup = new AirConditionerPositionUpCommand(receivers);
            //AirConditionerTempDownCommand tempdown = new AirConditionerTempDownCommand(receivers);
            //AirConditionerTempUpCommand tempup = new AirConditionerTempUpCommand(receivers);


            //Remoter r1 = new Remoter(onoff, tempup, tempdown, airup, airdown);




            //r1.ClickPositionDown();
            //r1.ClickTempUp();



            //foreach (var a in receivers)
            //    a.PrintAllParametars();

















        }
    }
}
