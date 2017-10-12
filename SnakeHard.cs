namespace SnakeGame
{
    public class SnakeHard : Snake
    {
        public SnakeHard(Point point, GameField gameField) : base(point, gameField)
        {
            moveCountMax = 17;
        }

        public override void Move()
        {
            base.Move();

            //end game if snake hits edge of screen
            //if (Head.X > _gameField.Width - 1) ENDGAME;
            //if (Head.X < 0) ENDGAME;
            //if (Head.Y > _gameField.Height - 1) ENDGAME;
            //if (Head.Y < 0) ENDGAME;
        }

        public override void Eat(Fruit f)
        {
            base.Eat(f);
            if (eatCount % 5 == 0 && moveCountMax > 6)
                moveCountMax--;
        }
    }
}