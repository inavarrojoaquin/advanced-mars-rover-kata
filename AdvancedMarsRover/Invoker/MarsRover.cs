using AdvancedMarsRover.Command;
using AdvancedMarsRover.Receiver;

namespace AdvancedMarsRover.Invoker
{
    public class MarsRover : IRemoteDevice
    {
        private string inputInstruction;
        private Plateu plateu;
        private ICommand command;

        public MarsRover(string inputInstruction)
        {
            this.inputInstruction = inputInstruction;
            plateu = new Plateu();
        }

        public void Move()
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
