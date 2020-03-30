using System;
using System.Collections.Generic;
using System.Text;
using MediatorDesignPattern.Components;
using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.ConcreteMediator
{
    public class ControlTowerMediator : IMediator
    {
      
        private static bool track;
        private List<IColleague> colleagues { get; set; }

        public void Register(IColleague colleague)
        {
            colleagues.Add(colleague);
        }
        
        public bool Getrack() { return track; }
        public ControlTowerMediator() 
        {
            colleagues = new List<IColleague>();
        }
      
        public void Ontrack()
        {
            track = false;
        }
        public void ClearTrack()
        {
           track = true;
        }

        public void TakeOff(int jmbg)
        {
            foreach (var a in colleagues)
            { 

                if (a.GetId() == jmbg)
                {
                    Ontrack();
                }
            }
        }
        public void Land(int jmbg)
        {
            foreach (var a in colleagues)
            {
                if (a.GetId() == jmbg)
                {
                   Ontrack();
                }
             
            }
        }
        public void SendMessage()
        {
            Console.WriteLine("Track is busy");
        }
    }

}

