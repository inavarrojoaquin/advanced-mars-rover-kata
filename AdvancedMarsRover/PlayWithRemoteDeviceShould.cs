using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedMarsRover
{
    public class PlayWithRemoteDeviceShould
    {
        [Test]
        public void GetExpectedForwardMovement()
        {
            IRemoteDevice remoteDevice = MarsRoverRemoteDevice.GetDevice();
            ICommand onCommand = new MoveRemoteDeviceForward(remoteDevice);
            DeviceButton deviceButton = new DeviceButton(onCommand);
            deviceButton.Press();

            //Assert.AreEqual("Move Forward");
        }
    }
}
