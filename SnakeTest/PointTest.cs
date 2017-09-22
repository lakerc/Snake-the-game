using System;
using SnakeGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SnakeTest
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void TestPointEqual()
        {
            Point p = new Point(0, 0);
            Point p2 = new Point(0, 0);

            Assert.IsTrue(p.Equals(p2));
            Assert.AreNotSame(p, p2);
        }

        [TestMethod]
        public void TestPointNotEqual()
        {
            Point p = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 0);
            Point p4 = new Point(1, 1);

            Assert.IsFalse(p.Equals(p2));
            Assert.IsFalse(p.Equals(p3));
            Assert.IsFalse(p.Equals(p4));
            
        }
    }
}
