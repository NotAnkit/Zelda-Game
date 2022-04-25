namespace Zelda_Game
{
    public class HButton : ICommand
    {
        private Game1 game;

        public HButton(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.manager.random = true;
            game.manager.LoadRooms(game);
        }
    }
}
