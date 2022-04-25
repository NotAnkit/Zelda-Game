namespace Zelda_Game
{
    public class AButton : ICommand
    {
        private Game1 game;

        public AButton(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            game.link.UseItem(game.inventoryDisplay.ItemASlot);
        }
    }
}
