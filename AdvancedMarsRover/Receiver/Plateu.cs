using AdvancedMarsRover.Domain;
using System.Collections.Generic;

namespace AdvancedMarsRover.Receiver
{
    public class Plateu
    {
        private const string OBSTACLE = "obstacle";
        private Position position;
        private Direction direction;
        private string[,] board;
        
        public Plateu(List<KeyValuePair<int, int>> obstacles)
        {
            board = CreateBoard(obstacles);
            direction = new Direction();
            position = new Position(0, 0);
        }

        public void TurnRight()
        {
            direction.TurnRight();
        }

        public void TurnLeft()
        {
            direction.TurnLeft();
        }

        public void MoveForward()
        {
            position = position.Update(direction.Name);
        }

        public string PrintCurrentPosition()
        {
            if (board[position.X, position.Y].ToString() == OBSTACLE)
                return board[position.X, position.Y].ToString();

            return board[position.X, position.Y].ToString() + ":" + direction.Name;
        }

        private string[,] CreateBoard(List<KeyValuePair<int, int>> obstacles)
        {
            string[,] board = new string[10, 10];

            for (var x = 0; x < board.GetLength(0); x++)
            {
                for (var y = 0; y < board.GetLength(1); y++)
                {
                    board[x, y] = x.ToString() + ":" + y.ToString();
                }
            }

            obstacles?.ForEach(obstacle => {
                board[obstacle.Key, obstacle.Value] = OBSTACLE;
            });

            return board;
        }
    }
}