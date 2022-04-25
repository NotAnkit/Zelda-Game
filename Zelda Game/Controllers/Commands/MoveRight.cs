namespace Zelda_Game
{
    public class MoveRight : ICommand
    {
        private Game1 game;

        public MoveRight(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.link.direction = "right";
        }
    }
}
