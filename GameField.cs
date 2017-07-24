using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameField
    {
        public int Width { get; set; }
        public int Height { get; set; }

        private List<List<string>> _field  = new List<List<string>>();
        public List<List<string>> Field
        {
            get { return _field; }
        }
        public GameField(int aWidth, int aHeight)
        {
            Width = aWidth;
            Height = aHeight;
            InitField();
        }

        private void InitField()
        {
            for (int i = 0; i < Width; i++)
            {
                List<string> lRow = new List<string>();
                for (int j = 0; j < Height; j++)
                {
                    lRow.Add(" ");
                }
                _field.Add(lRow);
            }
        }

        public void ClearField()
        {
            for (int i = 0; i < Width; i++)
            {
                List<string> lRow = new List<string>();
                for (int j = 0; j < Height; j++)
                {
                    _field[i][j] = " ";
                }
            }
        }

        public void Draw()
        {
            Console.Clear();
            Console.CursorVisible = false;
            
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width + 2; j++)
                {
                    if (j == 0 || j == Width + 1) Console.Write("#");
                    else Console.Write(_field[i][j - 1]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
