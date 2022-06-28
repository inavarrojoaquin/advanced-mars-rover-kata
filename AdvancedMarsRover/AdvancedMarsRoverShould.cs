using AdvancedMarsRover.Invoker;
using AdvancedMarsRover.Receiver;
using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedMarsRover
{
    public class AdvancedMarsRoverShould
    {
        #region The starting position 0:0:N
        [Test]
        public void StartAtCeroCeroNorth()
        {
            IRemoteDevice remoteDevice = new MarsRover();
            
            Assert.AreEqual("0:0:N", remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region Movement (M) from start position so final Direction keeps North
        [TestCase("M", "0:1:N")]
        [TestCase("MM", "0:2:N")]
        [TestCase("MMM", "0:3:N")]
        [TestCase("MMMM", "0:4:N")]
        public void MoveOnePositionToNorthFromStartingPosition(string input, string expected)
        {
            //hacer esto en un test nuevo
            //Plateu plateu = new Plateu(null);
            //IRemoteDevice remoteDevice = new MarsRover(plateu);
            // remoteDevice.Move(input);
            // si viene U haga un "undo" de un movimiento UUU (3 undos)
            IRemoteDevice remoteDevice = new MarsRover();
            remoteDevice.Move(input);

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region -> Turns direction to Right (R) from start position
        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        public void TurnDirectionToRightFromStartingPosition(string input, string expected)
        {
            IRemoteDevice remoteDevice = new MarsRover();
            remoteDevice.Move(input);

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region -> Turns direction to Left (L) from start position
        [TestCase("L", "0:0:W")]
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        [TestCase("LLLL", "0:0:N")]
        public void TurnDirectionToLeftFromStartingPosition(string input, string expected)
        {
            IRemoteDevice remoteDevice = new MarsRover();
            remoteDevice.Move(input);

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region -> Move position and turns to any direction
        [TestCase("MR", "0:1:E")]
        [TestCase("MMRR", "0:2:S")]
        [TestCase("ML", "0:1:W")]
        [TestCase("MMLL", "0:2:S")]
        public void MovePositionAndTurnDirectionFromStartingPosition(string input, string expected)
        {
            IRemoteDevice remoteDevice = new MarsRover();
            remoteDevice.Move(input);

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region -> Turn to any direction and Move position
        [TestCase("RM", "1:0:E")]
        [TestCase("RMMLM", "2:1:N")]
        [TestCase("MRMMLLM", "1:1:W")]
        [TestCase("MRMMLLML", "1:1:S")]
        public void TurnDirectionAndMovePositionFromStartingPosition(string input, string expected)
        {
            IRemoteDevice remoteDevice = new MarsRover();
            remoteDevice.Move(input);

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region -> Turn around
        [TestCase("MMMMMMMMMM", "0:0:N")]
        [TestCase("RMMMMMMMMMML", "0:0:N")]
        public void MoveAroundFromStartingPosition(string input, string expected)
        {
            IRemoteDevice remoteDevice = new MarsRover();
            remoteDevice.Move(input);

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region Moving around the plateu with obstacles
        [TestCase("MMMM", "O:0:2:N")]
        [TestCase("RMM", "O:1:0:E")]
        [TestCase("MMMRMLM", "O:0:2:N")]
        public void MoveAroundThePlateuWithObstacles(string input, string expected)
        {
            List<KeyValuePair<int, int>> obstacles = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(0,3),
                new KeyValuePair<int, int>(2,0)
            };
            Plateu plateu = new Plateu(obstacles);
            IRemoteDevice remoteDevice = new MarsRover(plateu);
            remoteDevice.Move(input);

            // si viene U haga un "undo" de un movimiento UUU (3 undos)

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion
    }
}