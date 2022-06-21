using AdvancedMarsRover.Invoker;
using NUnit.Framework;

namespace AdvancedMarsRover
{
    public class AdvancedMarsRoverShould
    {
        #region The starting position 0:0:N
        [Test]
        public void StartAtCeroCeroNorth()
        {
            IRemoteDevice remoteDevice = new MarsRover("");
            
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
            IRemoteDevice remoteDevice = new MarsRover(input);
            remoteDevice.Move();

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
            IRemoteDevice remoteDevice = new MarsRover(input);
            remoteDevice.Move();

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
            IRemoteDevice remoteDevice = new MarsRover(input);
            remoteDevice.Move();

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
            IRemoteDevice remoteDevice = new MarsRover(input);
            remoteDevice.Move();

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
            IRemoteDevice remoteDevice = new MarsRover(input);
            remoteDevice.Move();

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion

        #region -> Turn around
        [TestCase("MMMMMMMMMM", "0:0:N")]
        [TestCase("RMMMMMMMMMML", "0:0:N")]
        public void MoveAroundFromStartingPosition(string input, string expected)
        {
            IRemoteDevice remoteDevice = new MarsRover(input);
            remoteDevice.Move();

            Assert.AreEqual(expected, remoteDevice.PrintCurrentPosition());
        }
        #endregion
    }
}