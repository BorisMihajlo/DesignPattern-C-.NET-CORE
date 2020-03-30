using System;
using System.Collections.Generic;
using System.Text;
using MediatorDesignPattern.Components;
using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.ConcreteMediator
{
    public class ControlTowerMediator : IMediator
    {

        public static bool isTrackBusy;
        private List<BaseColleague> colleagues { get; set; }

        public void Register(BaseColleague colleague)
        {
            colleagues.Add(colleague);
            colleague.ControlTower = this;
        }
        
        public bool GetIsTrackBusy() 
        {
            return isTrackBusy; 
        }
        public ControlTowerMediator() 
        {
            colleagues = new List<BaseColleague>();
        }
      
        public void SetTrackBusy()
        {
            isTrackBusy = false;
        }
        public void ClearTrack()
        {
           isTrackBusy = true;
        }

        public void TakeOff(Guid jmbg)
        {
            foreach (var a in colleagues)
            { 

                if (a.GetId() == jmbg)
                {
                    SetTrackBusy();
                }
            }
        }
        public void Land(Guid jmbg)
        {
            foreach (var a in colleagues)
            {
                if (a.GetId() == jmbg)
                {
                   SetTrackBusy();
                }
             
            }
        }
        public void SendMessage()
        {
            Console.WriteLine("Track is busy");
        }
    }

}

