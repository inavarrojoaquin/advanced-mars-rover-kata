namespace AdvancedMarsRover
{
    public class DeviceButton
    {
        ICommand specificCommand;

        public DeviceButton(ICommand command)
        {
            specificCommand = command;
        }

        public void Press()
        {
            specificCommand.Execute();
        }

        public void PressUndo()
        {
            specificCommand.Undo();
        }
    }
}
