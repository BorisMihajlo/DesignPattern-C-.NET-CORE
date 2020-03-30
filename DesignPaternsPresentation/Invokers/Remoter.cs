using System;
using System.Collections.Generic;
using System.Text;
using CommandDesignPatern.Receivers;

namespace CommandDesignPatern.Invokers
{
    public class Remoter
    {
        ICommand OnOff;
        ICommand TempUp;
        ICommand TempDown;
        ICommand PositionUp;
        ICommand PositionDown;
        public Remoter(ICommand OnOff, ICommand TempUp, ICommand TempDown, ICommand PositionUp, ICommand PositionDown)
        {
            this.OnOff = OnOff;
            this.TempUp = TempUp;
            this.TempDown = TempDown;
            this.PositionDown = PositionDown;
            this.PositionUp = PositionUp;
        }
        public void ClickOnOffButton()
        {
            this.OnOff.execute();
        }

        public void ClickTempUp()
        {
            this.TempUp.execute();
        }

        public void ClickTempDown()
        {
            this.TempDown.execute();
        }

        public void ClickPositionUp()
        {
            this.PositionUp.execute();
        }

        public void ClickPositionDown()
        {
            this.PositionDown.execute();
        }
    }
}
