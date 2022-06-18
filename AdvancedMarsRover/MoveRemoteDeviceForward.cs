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

        public void Undo()
        {
            theRemoteDevice.MoveBackguard();
        }
    }
}
