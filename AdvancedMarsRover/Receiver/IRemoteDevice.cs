namespace AdvancedMarsRover.Receiver
{
    public interface IRemoteDevice
    {
        void TurnOn();
        void TurnOff();
        void MoveForward();
        void MoveBackguard();
        string PrintCurrentPosition();
    }
}
