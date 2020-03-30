using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Components
{
   public interface IColleague
    {
        public int GetId();
       
        public void TakeOff();
        public void Land();
    }
}
