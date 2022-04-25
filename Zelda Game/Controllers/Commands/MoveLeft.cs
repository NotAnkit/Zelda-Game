namespace Zelda_Game
{
    public class MoveLeft : ICommand
    {
        private Game1 game;

        public MoveLeft(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.link.direction = "left";
        }
    }
}
