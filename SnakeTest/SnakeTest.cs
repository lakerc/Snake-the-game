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
            Snake s = new Snake(new Point(0, 0), new GameField(20, 20));
            s.DirectionUp();
            s.Move();

            Assert.AreEqual(-1, s.Head.Y);
        }

        [TestMethod]
        public void SnakeMoveDownTest()
        {
            Snake s = new Snake(new Point(0, 0), new GameField(20, 20));
            s.DirectionDown();
            s.Move();

            Assert.AreEqual(1, s.Head.Y);
        }

        [TestMethod]
        public void SnakeMoveRightTest()
        {
            Snake s = new Snake(new Point(0, 0), new GameField(20, 20));
            s.DirectionRight();
            s.Move();

            Assert.AreEqual(1, s.Head.X);
        }

        [TestMethod]
        public void SnakeMoveLeftTest()
        {
            Snake s = new Snake(new Point(0, 0), new GameField(20, 20));
            s.DirectionLeft();
            s.Move();

            Assert.AreEqual(-1, s.Head.X);
        }

        [TestMethod]
        public void SnakeEatTest()
        {
            GameField field = new GameField(20, 20);
            field.Fruits[0].ResetPosition(new Point(11, 10));

            Snake s = new Snake(new Point(10, 10), field);
            
            s.DirectionRight();
            s.Move();
            s.Move();

            Assert.AreNotEqual(s.Tail.Count, 0);
            Assert.IsFalse(new Point(11, 10).Equals(field.Fruits[0].Position));
        }

    }
}
