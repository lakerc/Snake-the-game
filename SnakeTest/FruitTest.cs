using NUnit.Framework;
using SnakeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameTest
{
    [TestFixture]
    public class FruitTest
    {
        [Test]
        public void FruitResetPositionTest() {
            Fruit fruit = new Fruit(new Point(10, 10), new GameField(20, 20));
            Point fPoint = fruit.Position;
            
            fruit.ResetPosition(fruit.getField().RandomPointInField());

            Assert.AreNotEqual(fPoint, fruit.Position);
        }
    }
}
