namespace Zelda_Game
{
    public class MoveUp : ICommand
    {
        private Game1 game;

        public MoveUp(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.link.direction = "up";
        }
    }
}
