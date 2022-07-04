using System;

namespace AdvancedMarsRover.Domain
{
    public class Direction
    {
        public string Name { get; private set; }

        public Direction()
        {
            Name = Compass.N.ToString();
        }

        public void TurnRight()
        {
            Compass newCompass = (Compass)(((int)Enum.Parse<Compass>(Name) + 1) % 4);
            Name = newCompass.ToString();
        }

        public void TurnLeft()
        {
            Compass newCompass = (Compass)(((int)Enum.Parse<Compass>(Name) + 3) % 4);
            Name = newCompass.ToString();
        }
    }

    public enum Compass 
    {
        N = 0, 
        E = 1, 
        S = 2, 
        W = 3 
    }
}