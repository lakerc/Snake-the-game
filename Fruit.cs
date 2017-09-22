using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Fruit : IDrawable
    {
        private GameField _gameField;
        private Point _position;

        public int X { get { return _position.X; } }
        public int Y { get { return _position.Y; } }

        public Fruit(int aX, int aY)
        {
            _position = new Point(aX, aY);
        }
        public void SetField(GameField aGameField)
        {
            _gameField = aGameField;
        }

        public void ResetPosition(int aX, int aY)
        {
            _position = new Point(aX, aY);
        }

        public void Draw()
        {
            _gameField.Field[Y][X].Val = "$";
            _gameField.Field[Y][X].Color = ConsoleColor.Yellow;
        }

    }

}
