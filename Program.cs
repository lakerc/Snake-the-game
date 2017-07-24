using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Game Game = new Game(20, 20);
            bool _gameOver = false;
            while (!_gameOver)
            {
                _gameOver = Game.Input();
                _gameOver = Game.Logic();
                Game.Draw();
                System.Threading.Thread.Sleep(100);
            }
            
        }
    }
}
