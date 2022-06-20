using AdvancedMarsRover.Receiver;

namespace AdvancedMarsRover.Command
{
    public class MoveRemoteDeviceForwardCommand : ICommand
    {
        IRemoteDevice theRemoteDevice;
        public MoveRemoteDeviceForwardCommand(IRemoteDevice newRemoteDevice)
        {
            this.theRemoteDevice = newRemoteDevice;
        }
        public void Execute()
        {
            theRemoteDevice.MoveForward();
        }

        public void Undo()
        {
            theRemoteDevice.MoveBackguard();
        }
    }
}
