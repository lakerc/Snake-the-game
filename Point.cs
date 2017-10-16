using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Point
    {
        //Point's X and Y coordinates
        public int X { get; set; }
        public int Y { get; set; }

<<<<<<< HEAD
        //Point constructor
=======
        //Point constructor that takes 2 ints
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public Point(int aX, int aY)
        {
            X = aX;
            Y = aY;
        }

<<<<<<< HEAD
        //Point.Equals method, checks if this Point is equal to some other Point
=======
        //Equals method to see if a point matches this point
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public override bool Equals(object o)
        {
            Point p = (Point)o;
            return X == p.X && Y == p.Y;
        }

    }
}
