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

        public Point Position
        {
            get { return _position; }
        }

        public Fruit(Point point, GameField gameField)
        {
            _position = new Point(point.X, point.Y);
            SetField(gameField);
        }
        public void SetField(GameField aGameField)
        {
            _gameField = aGameField;
        }

        public void ResetPosition(Point point)
        {
            _position = new Point(point.X, point.Y);
        }

        public void Draw()
        {
            _gameField.Field[Position.Y][Position.X].Val = "$";
            _gameField.Field[Position.Y][Position.X].Color = ConsoleColor.Yellow;
        }

    }

}
