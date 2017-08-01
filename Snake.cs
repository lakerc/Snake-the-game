using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : IMovable, IDrawable
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

        public Snake(int aStartX, int aStartY)
        {
            Head = new Point(aStartX, aStartY);
        }

        public void SetField(GameField aGameField)
        {
            _gameField = aGameField;
        }
        public void Eat()
        {
            _tail.Insert(0,new Point(Head.X,Head.Y));
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
