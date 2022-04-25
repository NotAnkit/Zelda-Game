namespace Zelda_Game
{
    public class Reset : ICommand
    {
        private Game1 game;

        public Reset(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            var game2 = new Game1();
            game2.Run();
            game.Exit();
        }
    }
}
