using CommandDesignPatern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern.Invokers
{

    class RemoterCommand : ICommand
    {
        private List<IReceiver> _receivers;
        private Action _action;
        public enum Action { TempUp,TempDown, PositionDown, PositionUp};

        public bool IsSuccess;

        public void SuccessfullOperation()
        {
            IsSuccess = true;
        }
        
        public RemoterCommand(List<IReceiver> receivers, Action action)
        {
            this._receivers = receivers;
            this._action = action;
        }
        public void execute()
        {
           foreach (var acr in _receivers)
            {
                switch (_action)
                {
                    case Action.TempUp:
                        IsSuccess= acr.IncreaseTemperatureBool();
                        break;

                    case Action.TempDown:
                       IsSuccess= acr.DecreaseTemperatureBool();
                        break;

                    case Action.PositionUp:
                       IsSuccess= acr.SetUpAirFlowPositionBool();
                       
                        break;

                    case Action.PositionDown:
                       IsSuccess= acr.SetDownAirFlowPositionBool();
                       
                        break;


                }
            }
        }

        public void undo()
        {
           foreach(var acr in _receivers)
            {
                switch (_action)
                {
                    case Action.TempDown:
                        if (IsSuccess)
                            acr.IncreaseTemperature();
                        break;

                    case Action.TempUp:
                        if (IsSuccess)
                            acr.DecreaseTemperature();
                        break;

                    case Action.PositionDown:
                        if (IsSuccess==true)
                            acr.SetUpAirFlowPosition();
                        break;

                    case Action.PositionUp:
                        if (IsSuccess==true)
                        acr.SetDownAirFlowPosition();
                        break;



                }
            }
        }
    }
}
