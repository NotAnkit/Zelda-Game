namespace Zelda_Game
{
    public class Idle : ICommand
    {
        private Game1 game;

        public Idle(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.link.direction = "idle";
        }
    }
}
