using System;

namespace AdvancedMarsRover
{
    public class MarsRoverRemoteDevice
    {
        public static IRemoteDevice GetDevice()
        {
            return new MarsRover();
        }
    }
}