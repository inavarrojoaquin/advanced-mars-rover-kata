using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedMarsRover.Receiver
{
    class PlateuShould
    {
        [Test]
        public void GetExpectedInitialPosition() 
        {
            Plateu plateu = new Plateu(null);

            Assert.IsNotNull(plateu);
            Assert.AreEqual("0:0:N", plateu.PrintCurrentPosition());
        }

        [Test]
        public void TurnRight()
        {
            Plateu plateu = new Plateu(null);
            plateu.TurnRight();
            
            Assert.IsNotNull(plateu);
            Assert.AreEqual("0:0:E", plateu.PrintCurrentPosition());
        }

        [Test]
        public void TurnLeft()
        {
            Plateu plateu = new Plateu(null);
            plateu.TurnLeft();

            Assert.IsNotNull(plateu);
            Assert.AreEqual("0:0:W", plateu.PrintCurrentPosition());
        }

        [Test]
        public void MoveForward()
        {
            Plateu plateu = new Plateu(null);
            plateu.MoveForward();

            Assert.IsNotNull(plateu);
            Assert.AreEqual("0:1:N", plateu.PrintCurrentPosition());
        }

        [Test]
        public void CreateWithObstacles()
        {
            List<KeyValuePair<int, int>> obstacles = new List<KeyValuePair<int, int>> 
            { 
                new KeyValuePair<int, int>(0,1),
                new KeyValuePair<int, int>(0,2)
            };
            Plateu plateu = new Plateu(obstacles);
            plateu.MoveForward();

            Assert.IsNotNull(plateu);
            Assert.AreEqual("O:0:0:N", plateu.PrintCurrentPosition());
        }
    }
}
