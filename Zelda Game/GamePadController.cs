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
            if (userInput.IsButtonDown(Buttons.Back))
            {
                game.Exit();
            }
            if (userInput.IsButtonDown(Buttons.B))
            {
                var game2 = new Game1();
                game2.Run();
                game.Exit();
            }
            else if (capabilities.HasLeftYThumbStick)
            {
                if(userInput.ThumbSticks.Left.Y <= 0)
                    game.link.direction = "up";
                else
                    game.link.direction = "down";

            }
            else if (capabilities.HasLeftXThumbStick)
            {
                if (userInput.ThumbSticks.Left.X <= 0)
                    game.link.direction = "left";
                else
                    game.link.direction = "right";
            }
            else if (userInput.IsButtonDown(Buttons.Start) && !previousState.IsButtonDown(Buttons.Start))
            {
                game.manager.TransitionState = true;
                game.pause = !game.pause;

            }
            else if (userInput.IsButtonDown(Buttons.X) && !previousState.IsButtonDown(Buttons.X))
            {
                if (game.pause)
                {
                    game.itemSelectionState.weaponSelector.nextWeapon();
                }
                else
                {
                    game.link.UseItem(game.inventoryDisplay.ItemBSlot);
                }
            }
            else if (userInput.IsButtonDown(Buttons.A) && !previousState.IsButtonDown(Buttons.A))
            {
                game.link.UseItem(game.inventoryDisplay.ItemASlot);
            }
            /*else if (userInput.IsButtonUp(Keys.W) || userInput.IsButtonUp(Keys.A) || userInput.IsButtonUp(Keys.S) || userInput.IsButtonUp(Keys.D))
            {
                game.link.direction = "idle";
            }*/
        }
    }
}
