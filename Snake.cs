using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake : IMovable, IDrawable
    {
<<<<<<< HEAD
        //private vars

        //Snake Direction
=======
        //variable declarations
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        private Direction Dir = Direction.Up;

        //The playing field
        private GameField _gameField;

        //Texture for the Snake's head and body
        private static Texture _snakeHeadTex = null;
        private static Texture _snakeBodyTex = null;

        //color of the Snake
        Vector4 _snakeColor = new Vector4(175/255f, 96/255f, 255/255f, 1);

        //Get and Set the Snake's Head
        public Point Head { get; set; }

        //List of points representing the Snake's tail
        private List<Point> _tail = new List<Point>();

        //Tail getter
        public List<Point> Tail
        {
            get { return _tail; }
        }
    
<<<<<<< HEAD
        //Snake constructor
=======
        //Snake constructor, taking Point and GameField parameters
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public Snake(Point point, GameField gameField)
        {
            Head = new Point(point.X, point.Y);
            SetField(gameField);

<<<<<<< HEAD
            //set head and body textures
            if (_snakeHeadTex == null)
            {
                //_snakeHeadTex = Texture.LoadFromFile("textures/snakehead.png");
=======
            //Set snake head and tail textures if they're null
            if(_snakeHeadTex == null)
            {
               _snakeHeadTex = Texture.LoadFromFile("textures/snakehead.png");
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
            }
            if (_snakeBodyTex == null)
            {
<<<<<<< HEAD
                //_snakeBodyTex = Texture.LoadFromFile("textures/snakebody.png");
=======
               _snakeBodyTex = Texture.LoadFromFile("textures/snakebody.png");
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
            }
        }

<<<<<<< HEAD
        //Set the GameField
=======
        //GameField setter
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public void SetField(GameField aGameField)
        {
            _gameField = aGameField;
        }

<<<<<<< HEAD
        //Eat fruit
=======
        //Eat fruit when snake touches it
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public void Eat(Fruit f)
        {
            //add to snake and change fruit's position
            _tail.Insert(0, new Point(Head.X,Head.Y));
            f.ResetPosition(_gameField.RandomPointInField());
        }

<<<<<<< HEAD
        //Set Snake's Direction
=======
        //Set snake's movement direction
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public void SetDirection(Direction direction)
        {
            Dir = direction;
        }
        
<<<<<<< HEAD
        //Move the Snake
=======
        //Move the snake
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public void Move()
        {
            _tail.Insert(0, new Point(Head.X, Head.Y));
            _tail.RemoveAt(_tail.Count - 1);

<<<<<<< HEAD
            //Eat the fruit if Snake's head and fruit have the same position
=======
            //When the head and fruit are in the same position, eat the fruit
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
            if (Head.Equals(_gameField.Fruits[0].Position))
            {
                Eat(_gameField.Fruits[0]);
            }

<<<<<<< HEAD
            //Sets the direction of the Snake's Head
=======
            //Set the direction of the head
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
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

<<<<<<< HEAD
            //wrap Snake around to the other side if it goes beyond the GameField
=======
            //Wrap snake around if it goes beyond the game field
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
            if (Head.X > _gameField.Width - 1) Head.X = 0;
            if (Head.X < 0) Head.X = _gameField.Width - 1;
            if (Head.Y > _gameField.Height - 1) Head.Y = 0;
            if (Head.Y < 0) Head.Y = _gameField.Height - 1;
        }

<<<<<<< HEAD
        //Draw Snake's textures
=======
        //Draw the snake's textures
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        public void Draw()
        {
            GL.BindTexture(TextureTarget.Texture2D, _snakeHeadTex.ID);

            GL.PushMatrix();
            GL.Translate(Head.X * Cell.CELL_SIZE, Head.Y * Cell.CELL_SIZE, 0);

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(_snakeColor);
<<<<<<< HEAD

=======
            
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
            GL.TexCoord2(0, 0);
            GL.Vertex3(0, 0, -6);
            GL.TexCoord2(0, 1);
            GL.Vertex3(0, 32, -6);
            GL.TexCoord2(1, 1);
            GL.Vertex3(32,  32, -6);
            GL.TexCoord2(1, 0);
            GL.Vertex3( 32, 0, -6);

            GL.End();
            GL.PopMatrix();
            
            GL.BindTexture(TextureTarget.Texture2D, _snakeBodyTex.ID);

            //Snake tail texture
            foreach(Point p in Tail)
            {
                GL.PushMatrix();
                GL.Translate(p.X * Cell.CELL_SIZE, p.Y * Cell.CELL_SIZE, 0);

                GL.Begin(PrimitiveType.Quads);

                GL.TexCoord2(0, 0);
                GL.Vertex3(0, 0, -7);
                GL.TexCoord2(0, 1);
                GL.Vertex3(0, 32, -7);
                GL.TexCoord2(1, 1);
                GL.Vertex3(32, 32, -7);
                GL.TexCoord2(1, 0);
                GL.Vertex3(32, 0, -7);

                GL.End();
                GL.PopMatrix();
            }
<<<<<<< HEAD

=======
>>>>>>> 4dc72c0953fc22d78da5379359f96d62f134694f
        }
    }
}
