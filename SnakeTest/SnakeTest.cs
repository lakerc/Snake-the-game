using System;
using SnakeGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SnakeGameTest
{
    [TestClass]
    public class SnakeTest
    {
        [TestMethod]
        public void SnakeMoveUpTest()
        {
            Snake s = new Snake(0, 0);
            s.DirectionUp();
            s.Move();

            Assert.AreEqual(-1, s.Head.Y);
        }

        [TestMethod]
        public void SnakeMoveDownTest()
        {
            Snake s = new Snake(0, 0);
            s.DirectionDown();
            s.Move();

            Assert.AreEqual(1, s.Head.Y);
        }

        [TestMethod]
        public void SnakeMoveRightTest()
        {
            Snake s = new Snake(0, 0);
            s.DirectionRight();
            s.Move();

            Assert.AreEqual(1, s.Head.X);
        }

        [TestMethod]
        public void SnakeMoveLeftTest()
        {
            Snake s = new Snake(0, 0);
            s.DirectionLeft();
            s.Move();

            Assert.AreEqual(-1, s.Head.Y);
        }


    }
}
