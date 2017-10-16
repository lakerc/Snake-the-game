using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Program
    {
        //Main method
        static void Main(string[] args)
        {
            using(Game game = new Game(25, 25))
            {
                //Run the game
                game.Run(10, 60);
            }
        }
    }
}
