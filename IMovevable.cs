using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Direction { Stop = 0, Left, Right, Up, Down };

    public interface IMovable
    {
        void SetDirection(Direction direction);
        void Move();
    }
}
