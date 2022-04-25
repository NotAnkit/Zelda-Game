namespace Zelda_Game
{
    public class Pause : ICommand
    {
        private Game1 game;

        public Pause(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.manager.TransitionState = true;
            if (game.gameManager.State == "paused")
            {
                game.gameManager.State = "running";
            }
            else
            {
                game.gameManager.State = "paused";
            }
        }
    }
}
