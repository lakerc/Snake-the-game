using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Game 
    {

        private Snake _snake;
        private GameField _gameField;
        private bool _gameOver; 

        public Game(int aWidth, int aHeight)
        {
            _gameField = new GameField(aWidth, aHeight);
            _snake = new Snake(new Point(aWidth / 2, aHeight / 2), _gameField);
            _snake.SetField(_gameField);
            _gameOver = false;
        }

        private bool Input()
        {
            ConsoleKeyInfo lKey = new ConsoleKeyInfo();
            if (Console.KeyAvailable)
            {
                lKey = Console.ReadKey(true);
            }

            switch (lKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    _snake.SetDirection(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    _snake.SetDirection(Direction.Right);
                    break;
                case ConsoleKey.UpArrow:
                    _snake.SetDirection(Direction.Up);
                    break;
                case ConsoleKey.DownArrow:
                    _snake.SetDirection(Direction.Down);
                    break;
                case ConsoleKey.Q:
                    return true;
                default:
                    break;
            }
            return false;
        }

        private bool Logic()
        {
            _gameField.ClearField();

            _snake.Move();

            
            foreach (var i in _snake.Tail)
            {
                if (i.X == _snake.Head.X && i.Y == _snake.Head.Y) return true;
            }
            return false;
        }


        private void Draw()
        {
            _snake.Draw();

            foreach(Fruit f in _gameField.Fruits)
            {
                f.Draw();
            }

            _gameField.Draw();
        }

        public void Run()
        {
            while (!_gameOver)
            {
                _gameOver = Input();
                _gameOver = Logic();
                Draw();
                System.Threading.Thread.Sleep(100);
            }
        }
    }

    
}
