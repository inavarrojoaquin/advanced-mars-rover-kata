using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedMarsRover
{
    public class MoveRemoteDeviceForward : ICommand
    {
        IRemoteDevice theRemoteDevice;
        public MoveRemoteDeviceForward(IRemoteDevice newRemoteDevice)
        {
            this.theRemoteDevice = newRemoteDevice;
        }
        public void Execute()
        {
            theRemoteDevice.MoveForward();
        }
    }
}
