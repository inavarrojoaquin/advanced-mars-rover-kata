using System;

namespace AdvancedMarsRover
{
    public class Direction
    {
        public string Name { get; private set; }

        public Direction()
        {
            Name = Directions.N.ToString();            
        }

        public void TurnRight()
        {
            if (Name == "N") { Name = Directions.E.ToString(); return; }
            if (Name == "E") { Name = Directions.S.ToString(); return; }
            if (Name == "S") { Name = Directions.W.ToString(); return; }
            if (Name == "W") { Name = Directions.N.ToString(); return; }
        }

        public void TurnLeft()
        {
            if (Name == "N") { Name = Directions.W.ToString(); return; }
            if (Name == "W") { Name = Directions.S.ToString(); return; }
            if (Name == "S") { Name = Directions.E.ToString(); return; }
            if (Name == "E") { Name = Directions.N.ToString(); return; }
        }
    }

    public enum Directions
    {
        N,
        S,
        E,
        W
    }
}