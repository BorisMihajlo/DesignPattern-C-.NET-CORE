using System;
using System.Collections.Generic;
using System.Text;
using MediatorDesignPattern.Components;
using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.ConcreteMediator
{
    public class ControlTowerMediator : IMediator
    {
      
        public static bool track;
        public List<IColleague> colleague { get; set; }

        
        public bool Getrack() { return track; }
        public ControlTowerMediator() 
        {
            colleague = new List<IColleague>();
        
        }
      
        public void Ontrack()
        {
            track = false;
        }
        public void ClearTrack()
        {
           track = true;
            
        }

        public void FlightOff(int jmbg)
        {
            foreach (var a in colleague)
            { 
                
                if (a.GetId() == jmbg)
                {
                    Ontrack();
                   
                }
           
            }
            
        }
        public void Ground(int jmbg)
        {
            foreach (var a in colleague)
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

