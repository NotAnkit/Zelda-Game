namespace Zelda_Game
{
    public class BButton : ICommand
    {
        private Game1 game;

        public BButton(Game1 game1)
        {
            game = game1;
        }

        public void Execute()
        {
            if (game.gameManager.State == "paused")
            {
                game.itemSelectionState.weaponSelector.NextWeapon();
            }
            else
            {
                game.link.UseItem(game.inventoryDisplay.ItemBSlot);
            }
        }
    }
}
