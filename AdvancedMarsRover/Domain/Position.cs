using System;

namespace AdvancedMarsRover.Domain
{
    public class Position
    {
        public int X { get; internal set; }
        public int Y { get; internal set; }

        public Position(int positionX, int positionY)
        {
            X = positionX;
            Y = positionY;
        }

        public Position Update(string direction, bool isUndoMovement = false)
        {
            if (direction == Compass.N.ToString()) Y = !isUndoMovement ? Y + 1 : Y - 1;
            if (direction == Compass.E.ToString()) X = !isUndoMovement ? X + 1 : X - 1;
            if (direction == Compass.S.ToString()) Y = !isUndoMovement ? Y - 1 : Y + 1;
            if (direction == Compass.W.ToString()) X = !isUndoMovement ? X - 1 : X + 1;

            if (X > 9) X -= 10;
            if (Y > 9) Y -= 10;
            if (X < 0) X += 10;
            if (Y < 0) Y += 10;

            return new Position(X, Y);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}