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

        private List<List<Cell>> _field  = new List<List<Cell>>();
        public List<List<Cell>> Field
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
            for (int i = 0; i < Height; i++)
            {
                List<Cell> lRow = new List<Cell>();
                for (int j = 0; j < Width; j++)
                {
                    Cell lCell = new Cell(" ", ConsoleColor.White);
                    lRow.Add(lCell);
                }
                _field.Add(lRow);
            }
        }

        public void ClearField()
        {
            for (int i = 0; i < Height; i++)
            {
                //List<string> lRow = new List<string>();
                for (int j = 0; j < Width; j++)
                {
                    _field[i][j].Val = " ";
                    _field[i][j].Color = ConsoleColor.White;
                }
            }
        }

        public void Draw()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width + 2; j++)
                {
                    if (j == 0 || j == Width + 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("#");
                        //Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = _field[i][j - 1].Color;
                        Console.Write(_field[i][j - 1].Val);
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
