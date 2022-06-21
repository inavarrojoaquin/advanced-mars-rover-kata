using AdvancedMarsRover.Receiver;

namespace AdvancedMarsRover.Command
{
    public class TurnLeftCommand : ICommand
    {
        private Plateu plateu;

        public TurnLeftCommand(Plateu plateu)
        {
            this.plateu = plateu;
        }

        public void Execute()
        {
            plateu.TurnLeft();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}