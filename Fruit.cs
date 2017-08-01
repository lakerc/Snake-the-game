using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Fruit : IDrawable
    {
        private GameField _gameField;
        private int _x;
        public int X { get { return _x; } }
        private int _y;
        public int Y { get { return _y; } }

        public Fruit(int aX, int aY)
        {
            _x = aX;
            _y = aY;
        }
        public void SetField(GameField aGameField)
        {
            _gameField = aGameField;
        }

        public void ResetPosition(int aX, int aY)
        {
            _x = aX;
            _y = aY;
        }
        public void Draw()
        {
            _gameField.Field[_y][_x].Val = "$";
            _gameField.Field[_y][_x].Color = ConsoleColor.Yellow;
        }

    }

}
