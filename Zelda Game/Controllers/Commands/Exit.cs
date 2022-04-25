namespace Zelda_Game
{
    public class Exit : ICommand
    {
        private Game1 game;

        public Exit(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.Exit();
        }
    }
}
