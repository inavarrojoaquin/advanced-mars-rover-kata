using AdvancedMarsRover.Receiver;

namespace AdvancedMarsRover.Command
{
    public class TurnRightCommand : ICommand
    {
        private Plateu plateu;

        public TurnRightCommand(Plateu plateu)
        {
            this.plateu = plateu;
        }

        public void Execute()
        {
            plateu.TurnRight();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}