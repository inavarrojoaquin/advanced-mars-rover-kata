using NUnit.Framework;

namespace AdvancedMarsRover
{
    public class PlayWithRemoteDeviceShould
    {
        IRemoteDevice remoteDevice = MarsRoverRemoteDevice.GetDevice();
        [Test]
        public void MoveForward()
        {
            MoveRemoteDeviceForward moveForwardCommand = new MoveRemoteDeviceForward(remoteDevice);
            DeviceButton deviceButton = new DeviceButton(moveForwardCommand);
            deviceButton.Press();
        }

        [Test]
        public void UndoMovement()
        {
            MoveRemoteDeviceForward moveForwardCommand = new MoveRemoteDeviceForward(remoteDevice);
            DeviceButton deviceButton = new DeviceButton(moveForwardCommand);
            deviceButton.Press();
            deviceButton.PressUndo();
        }
    }
}
