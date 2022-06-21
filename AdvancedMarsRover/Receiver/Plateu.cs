using AdvancedMarsRover.Domain;

namespace AdvancedMarsRover.Receiver
{
    public class Plateu
    {
        private Position position;
        private Direction direction;
        private string[,] board;
        
        public Plateu()
        {
            board = CreateBoard();
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

        public void UpdatePosition()
        {
            position = position.Update(direction.Name);
        }

        public string PrintCurrentPosition()
        {
            return board[position.X, position.Y].ToString() + ":" + direction.Name;
        }

        private string[,] CreateBoard()
        {
            string[,] board = new string[10, 10];
            
            for (var x = 0; x < board.GetLength(0); x++) 
            {
                for (var y = 0; y < board.GetLength(1); y++) 
                {
                    board[x, y] = x.ToString() +":"+ y.ToString();
                }
            }

            return board;
        }
    }
}