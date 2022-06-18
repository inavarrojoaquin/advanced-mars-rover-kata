using System.Diagnostics;

namespace AdvancedMarsRover
{
    public class MarsRover : IRemoteDevice
    {
        public void MoveForward()
        {
            Debug.WriteLine("Move Forward");
        }

        public void MoveBackguard()
        {
            Debug.WriteLine("Move backguard");
        }
    }
}
