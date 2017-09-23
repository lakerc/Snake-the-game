using System;
using SnakeGame;
using NUnit.Framework;

namespace SnakeGameTest
{
    [TestFixture]
    public class SnakeTest
    {
        [Test]
        public void SnakeMoveUpTest()
        {
            Snake s = new Snake(new Point(10, 10), new GameField(20, 20));
            s.DirectionUp();
            s.Move();

            Assert.AreEqual(9, s.Head.Y);
            Assert.AreEqual(10, s.Head.X);
        }

        [Test]
        public void SnakeMoveDownTest()
        {
            Snake s = new Snake(new Point(10, 10), new GameField(20, 20));
            s.DirectionDown();
            s.Move();

            Assert.AreEqual(11, s.Head.Y);
            Assert.AreEqual(10, s.Head.X);
        }

        [Test]
        public void SnakeMoveRightTest()
        {
            Snake s = new Snake(new Point(10, 10), new GameField(20, 20));
            s.DirectionRight();
            s.Move();

            Assert.AreEqual(11, s.Head.X);
            Assert.AreEqual(10, s.Head.Y);
        }

        [Test]
        public void SnakeMoveLeftTest()
        {
            Snake s = new Snake(new Point(10, 10), new GameField(20, 20));
            s.DirectionLeft();
            s.Move();

            Assert.AreEqual(9, s.Head.X);
            Assert.AreEqual(10, s.Head.Y);
        }

        [Test]
        public void SnakeEatTest()
        {
            GameField field = new GameField(20, 20);
            field.Fruits[0].ResetPosition(new Point(11, 10));

            Snake s = new Snake(new Point(10, 10), field);
            
            s.DirectionRight();
            s.Move();
            s.Move();

            Assert.AreNotEqual(0, s.Tail.Count);
            Assert.IsFalse(new Point(11, 10).Equals(field.Fruits[0].Position));
        }

    }
}
