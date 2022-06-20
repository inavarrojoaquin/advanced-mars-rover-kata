using AdvancedMarsRover.Receiver;
using System;

namespace AdvancedMarsRover
{
    public class MarsRoverRemoteDevice
    {
        public static IRemoteDevice GetDevice()
        {
            return new MarsRover("");
        }

        public static IRemoteDevice GetDeviceWithInstruction(string input)
        {
            return new MarsRover(input);
        }
    }
}