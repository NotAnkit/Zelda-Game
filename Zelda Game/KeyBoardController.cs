using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        //comment
        private KeyboardState userInput;
        private KeyboardState previousState;
        private Game1 game;
        public KeyBoardController(Game1 _game)
        {
            game = _game;
        }
        public void Update()
        {
            previousState = userInput;
            userInput = Keyboard.GetState();
            if (userInput.IsKeyDown(Keys.Q))
            {
                game.Exit();
            }
            if (userInput.IsKeyDown(Keys.R))
            {
                var game2 = new Game1();
                game2.Run();
                game.Exit();
            }
            else if (userInput.IsKeyDown(Keys.Up))
            {
                game.link.direction = "up";

            }
            else if (userInput.IsKeyDown(Keys.Left))
            {
                game.link.direction = "left";

            }
            else if (userInput.IsKeyDown(Keys.Down))
            {
                game.link.direction = "down";

            }
            else if (userInput.IsKeyDown(Keys.Right))
            {
                game.link.direction = "right";

            }
            /*else if (userInput.IsKeyDown(Keys.Z) || userInput.IsKeyDown(Keys.N))
            {

                game.link.UseSword();


            }
            else if (userInput.IsKeyDown(Keys.D1) && !previousState.IsKeyDown(Keys.D1))
            {

                game.link.UseItem("bomb");


            }
            else if (userInput.IsKeyDown(Keys.D2) && !previousState.IsKeyDown(Keys.D2))
            {

                game.link.UseItem("blue-arrow");


            }
            else if (userInput.IsKeyDown(Keys.D3) && !previousState.IsKeyDown(Keys.D3))
            {

                game.link.UseItem("green-arrow");


            }
            else if (userInput.IsKeyDown(Keys.D4) && !previousState.IsKeyDown(Keys.D4))
            {
                game.link.UseItem("fire");
            }

            else if (userInput.IsKeyDown(Keys.D5) && !previousState.IsKeyDown(Keys.D5))
            {
                game.link.UseItem("green-boomerang");
            }
            else if (userInput.IsKeyDown(Keys.D6) && !previousState.IsKeyDown(Keys.D6))
            {
                game.link.UseItem("blue-boomerang");
            }*/
            else if (userInput.IsKeyDown(Keys.P) && !previousState.IsKeyDown(Keys.P))
            {
                game.tansitionState = !game.pause;
                game.pause = !game.pause;
                
            }
            else if (userInput.IsKeyDown(Keys.B) && !previousState.IsKeyDown(Keys.B))
            {
                game.link.UseItem(game.inventoryDisplay.ItemBSlot);
            }
            else if (userInput.IsKeyDown(Keys.A) && !previousState.IsKeyDown(Keys.A))
            {
                game.link.UseItem(game.inventoryDisplay.ItemASlot);
            }
            else if (userInput.IsKeyUp(Keys.W) || userInput.IsKeyUp(Keys.A) || userInput.IsKeyUp(Keys.S) || userInput.IsKeyUp(Keys.D))
            {
                game.link.direction = "idle";
            }
        }
    }
}