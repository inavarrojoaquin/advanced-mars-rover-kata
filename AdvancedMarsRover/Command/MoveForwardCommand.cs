using AdvancedMarsRover.Receiver;

namespace AdvancedMarsRover.Command
{
    public class MoveForwardCommand : ICommand
    {
        private Plateu plateu;

        public MoveForwardCommand(Plateu plateu)
        {
            this.plateu = plateu;
        }

        public void Execute()
        {
            plateu.MoveForward();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}
