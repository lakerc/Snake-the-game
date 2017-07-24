using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    interface IDrawable
    {
        void SetField(GameField aGameField);
        void Draw();
    }
}
