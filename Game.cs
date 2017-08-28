using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Game 
    {
        private Random _rand = new Random(); 
        private Snake _snake;
        private Fruit _fruit;
        private GameField _gameField;
        private bool _gameOver; 

        public Game(int aWidth, int aHeight)
        {
            _gameField = new GameField(aWidth, aHeight);
            _snake = new Snake(aWidth / 2, aHeight / 2);
            _snake.SetField(_gameField);
            _fruit = new Fruit(_rand.Next(aWidth), _rand.Next(aHeight));
            _fruit.SetField(_gameField);
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
                    _snake.DirectionLeft();
                    break;
                case ConsoleKey.RightArrow:
                    _snake.DirectionRight();
                    break;
                case ConsoleKey.UpArrow:
                    _snake.DirectionUp();
                    break;
                case ConsoleKey.DownArrow:
                    _snake.DirectionDown();
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
            if (_snake.Head.X == _fruit.X && _snake.Head.Y == _fruit.Y)
            {
                _fruit.ResetPosition(_rand.Next(_gameField.Width), _rand.Next(_gameField.Height));
                _snake.Eat();
            }
            _snake.Move();
            if (_snake.Head.X > _gameField.Width - 1) _snake.Head.X = 0;
            if (_snake.Head.X < 0) _snake.Head.X = _gameField.Width - 1;
            if (_snake.Head.Y > _gameField.Height - 1) _snake.Head.Y = 0;
            if (_snake.Head.Y < 0) _snake.Head.Y = _gameField.Height - 1;
            
            foreach (var i in _snake.Tail)
            {
                if (i.X == _snake.Head.X && i.Y == _snake.Head.Y) return true;
            }
            return false;
        }


        private void Draw()
        {
            _snake.Draw();
            _fruit.Draw();
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
