using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedMarsRover
{
    public class UndoRemoteDeviceMovement : ICommand
    {
        IRemoteDevice theRemoteDevice;
        public UndoRemoteDeviceMovement(IRemoteDevice newRemoteDevice)
        {
            this.theRemoteDevice = newRemoteDevice;
        }
        public void Execute()
        {
            theRemoteDevice.UndoLastMovement();
        }
    }
}
