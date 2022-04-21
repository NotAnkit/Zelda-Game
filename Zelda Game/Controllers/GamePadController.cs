using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class GamePadController : IController
    {
        private GamePadState userInput;
        private GamePadState previousState;
        private GamePadCapabilities capabilities;
        private readonly Game1 game;

        public GamePadController(Game1 _game)
        {
            game = _game;
            capabilities = GamePad.GetCapabilities(PlayerIndex.One);
        }
        public void Update()
        {
            previousState = userInput;
            userInput = GamePad.GetState(PlayerIndex.One);
            if (userInput.IsButtonDown(Buttons.Y) && !previousState.IsButtonDown(Buttons.Y))
            {
                game.Exit();
            }
            if (userInput.IsButtonDown(Buttons.B) && !previousState.IsButtonDown(Buttons.B))
            {
                var game2 = new Game1();
                game2.Run();
                game.Exit();
            }
            if (capabilities.HasLeftYThumbStick && capabilities.HasLeftXThumbStick)
            {
                if (userInput.ThumbSticks.Left.Y > 0)
                    game.link.direction = "up";
                else if (userInput.ThumbSticks.Left.Y < 0)
                    game.link.direction = "down";
                else if (userInput.ThumbSticks.Left.X < 0)
                    game.link.direction = "left";
                else if (userInput.ThumbSticks.Left.X > 0)
                    game.link.direction = "right";
                else
                    game.link.direction = "idle";

            }
            if (userInput.IsButtonDown(Buttons.Start) && !previousState.IsButtonDown(Buttons.Start))
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
            if (userInput.IsButtonDown(Buttons.X) && !previousState.IsButtonDown(Buttons.X))
            {
                if (game.gameManager.State == "paused")
                {
                    game.itemSelectionState.weaponSelector.nextWeapon();
                }
                else
                {
                    game.link.UseItem(game.inventoryDisplay.ItemBSlot);
                }
            }
            if (userInput.IsButtonDown(Buttons.A) && !previousState.IsButtonDown(Buttons.A))
            {
                game.link.UseItem(game.inventoryDisplay.ItemASlot);
            }
          
        }
    }
}
