namespace AdvancedMarsRover.Invoker
{
    public interface IRemoteDevice
    {
        void Move();
        string PrintCurrentPosition();
    }
}
