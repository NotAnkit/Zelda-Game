namespace Zelda_Game
{
    public class MoveDown : ICommand
    {
        private Game1 game;

        public MoveDown(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.link.direction = "down";
        }
    }
}