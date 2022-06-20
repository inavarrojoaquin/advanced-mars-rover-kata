using AdvancedMarsRover.Receiver;

namespace AdvancedMarsRover.Command
{
    public class TurnRemoteDeviceOnCommand : ICommand
    {
        private IRemoteDevice remoteDevice;

        public TurnRemoteDeviceOnCommand(IRemoteDevice remoteDevice)
        {
            this.remoteDevice = remoteDevice;
        }

        public void Execute()
        {
            remoteDevice.TurnOn();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}