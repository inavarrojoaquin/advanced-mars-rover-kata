namespace AdvancedMarsRover.Invoker
{
    public interface IRemoteDevice
    {
        void Move(string input);
        string PrintCurrentPosition();
    }
}
