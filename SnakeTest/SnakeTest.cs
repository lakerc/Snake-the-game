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
            s.SetDirection(Direction.Up);
            s.Move();

            Assert.AreEqual(9, s.Head.Y);
            Assert.AreEqual(10, s.Head.X);
        }

        [Test]
        public void SnakeMoveDownTest()
        {
            Snake s = new Snake(new Point(10, 10), new GameField(20, 20));
            s.SetDirection(Direction.Down);
            s.Move();

            Assert.AreEqual(11, s.Head.Y);
            Assert.AreEqual(10, s.Head.X);
        }

        [Test]
        public void SnakeMoveRightTest()
        {
            Snake s = new Snake(new Point(10, 10), new GameField(20, 20));
            s.SetDirection(Direction.Right);
            s.Move();

            Assert.AreEqual(11, s.Head.X);
            Assert.AreEqual(10, s.Head.Y);
        }

        [Test]
        public void SnakeMoveLeftTest()
        {
            Snake s = new Snake(new Point(10, 10), new GameField(20, 20));
            s.SetDirection(Direction.Left);
            s.Move();

            Assert.AreEqual(9, s.Head.X);
            Assert.AreEqual(10, s.Head.Y);
        }

        [Test]
        public void SnakeEatTest()
        {
            GameField field = null;
            try
            {
                 field = new GameField(20, 20);
            }
            catch (System.ArgumentException ex) { Console.Write("fuck, that wasn't supposed to happen");}

            field.Fruits[0].ResetPosition(new Point(11, 10));
            Snake s = new Snake(new Point(10, 10), field);
            s.SetDirection(Direction.Right);
            s.Move();
            s.Move();

            Assert.AreNotEqual(0, s.Tail.Count);
            Assert.IsFalse(new Point(11, 10).Equals(field.Fruits[0].Position));
        }

    }
}
