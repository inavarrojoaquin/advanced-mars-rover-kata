﻿using System;

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

        public Position Update(string direction)
        {
            if (direction == Directions.N.ToString()) Y += 1;
            if (direction == Directions.E.ToString()) X += 1;
            if (direction == Directions.S.ToString()) Y -= 1;
            if (direction == Directions.W.ToString()) X -= 1;

            if (X > 9) X -= 10;
            if (Y > 9) Y -= 10;
            if (X < 0) X += 10;
            if (Y < 0) Y += 10;

            return new Position(X, Y);
        }

        internal Position Undo(string direction)
        {
            if (direction == Directions.N.ToString()) Y -= 1;
            if (direction == Directions.E.ToString()) X -= 1;
            if (direction == Directions.S.ToString()) Y += 1;
            if (direction == Directions.W.ToString()) X += 1;

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