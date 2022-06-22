using AdvancedMarsRover.Command;
using AdvancedMarsRover.Receiver;

namespace AdvancedMarsRover.Invoker
{
    public class MarsRover : IRemoteDevice
    {
        private Plateu plateu;
        private ICommand command;

        public MarsRover()
        {
            plateu = new Plateu(null);
        }

        public void Move(string inputInstruction)
        {
            if (inputInstruction.Length == 0) return;

            for (var i = 0; i < inputInstruction.Length; i++)
            {
                if (inputInstruction[i] == 'R') command = new TurnRightCommand(plateu);
                if (inputInstruction[i] == 'L') command = new TurnLeftCommand(plateu);
                if (inputInstruction[i] == 'M') command = new MoveForwardCommand(plateu);

                command.Execute();
            }
        }

        public string PrintCurrentPosition()
        {
            return plateu.PrintCurrentPosition();
        }
    }
}
