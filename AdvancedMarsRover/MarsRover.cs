using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdvancedMarsRover
{
    public class MarsRover : IRemoteDevice
    {
        public void MoveForward()
        {
            Debug.WriteLine("Move Forward");
        }

        public void UndoLastMovement()
        {
            Debug.WriteLine("Undo last movement");
        }
    }
}
