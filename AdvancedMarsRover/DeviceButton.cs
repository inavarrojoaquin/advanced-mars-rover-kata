using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedMarsRover
{
    public class DeviceButton
    {
        ICommand theCommand;

        public DeviceButton(ICommand command)
        {
            theCommand = command;
        }

        public void Press()
        {
            theCommand.Execute();
        }
    }
}
