using AdvancedMarsRover.Domain;
using System.Diagnostics;

namespace AdvancedMarsRover.Receiver
{
    public class MarsRover : IRemoteDevice
    {
        private string inputInstruction;
        private Plateu plateu;

        public MarsRover(string inputInstruction)
        {
            this.inputInstruction = inputInstruction;            
        }

        public void TurnOn()
        {
            Debug.WriteLine("Turn ON");
            plateu = new Plateu();
        }

        public void TurnOff()
        {
            Debug.WriteLine("Turn OFF");
        }

        public void MoveForward()
        {
            Debug.WriteLine("Move Forward");

            plateu.Move(inputInstruction);
        }

        public void MoveBackguard()
        {
            Debug.WriteLine("Move backguard");
        }

        public string PrintCurrentPosition()
        {
            return plateu.PrintCurrentPosition();
        }
    }
}
