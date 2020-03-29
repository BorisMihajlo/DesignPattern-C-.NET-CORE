using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatern
{
    public interface ICommand
    {
        public void execute();
        public void unexecute();
    }
}
