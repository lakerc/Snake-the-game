using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake : IMovable, IDrawable
    {
        private enum Direction { Stop = 0, Left, Right, Up, Down }
        private Direction Dir = Direction.Stop;
        private GameField _gameField;
        public Point Head { get; set; }
        private List<Point> _tail = new List<Point>();
        public List<Point> Tail
        {
            get { return _tail; }
        }

        public Snake(Point point, GameField gameField)
        {
            Head = new Point(point.X, point.Y);
            SetField(gameField);
        }

        public void SetField(GameField aGameField)
        {
            _gameField = aGameField;
        }
        public void Eat(Fruit f)
        {
            _tail.Insert(0, new Point(Head.X,Head.Y));
            f.ResetPosition(_gameField.RandomPointInField());
        }



        public void DirectionLeft()
        {
            Dir = Direction.Left;
        }

        public void DirectionRight()
        {
            Dir = Direction.Right;
        }

        public void DirectionUp()
        {
            Dir = Direction.Up;
        }

        public void DirectionDown()
        {
            Dir = Direction.Down;
        }

        public void Move()
        {
            _tail.Insert(0, new Point(Head.X, Head.Y));
            _tail.RemoveAt(_tail.Count - 1);

            if (Head.Equals(_gameField.Fruits[0].Position))
            {
                Eat(_gameField.Fruits[0]);
            }

            switch (Dir)
            {
                case Direction.Left:
                    Head.X--;
                    break;
                case Direction.Right:
                    Head.X++;
                    break;
                case Direction.Up:
                    Head.Y--;
                    break;
                case Direction.Down:
                    Head.Y++;
                    break;
                default:
                    break;
            }

            if (Head.X > _gameField.Width - 1) Head.X = 0;
            if (Head.X < 0) Head.X = _gameField.Width - 1;
            if (Head.Y > _gameField.Height - 1) Head.Y = 0;
            if (Head.Y < 0) Head.Y = _gameField.Height - 1;

        }

        public void Draw()
        {
            _gameField.Field[Head.Y][Head.X].Val = "O";
            _gameField.Field[Head.Y][Head.X].Color = ConsoleColor.Green;
            foreach (Point t in Tail)
            {
                _gameField.Field[t.Y][t.X].Val = "o";
                _gameField.Field[t.Y][t.X].Color = ConsoleColor.Green;
            }
        }
    }
}
