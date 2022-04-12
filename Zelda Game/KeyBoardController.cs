﻿using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        private KeyboardState userInput;
        private KeyboardState previousState;
        private readonly Game1 game;

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
            else if (userInput.IsKeyDown(Keys.P) && !previousState.IsKeyDown(Keys.P))
            {
                game.manager.TransitionState = true;
                game.pause = !game.pause;
                
            }
            else if (userInput.IsKeyDown(Keys.B) && !previousState.IsKeyDown(Keys.B))
            {
                if (game.pause)
                {

                }
                else
                {
                    game.link.UseItem(game.inventoryDisplay.ItemBSlot);
                }
                
            }
            else if (userInput.IsKeyDown(Keys.A) && !previousState.IsKeyDown(Keys.A))
            {
                game.link.UseItem(game.inventoryDisplay.ItemASlot);
            }
            else if (userInput.IsKeyDown(Keys.E) && !previousState.IsKeyDown(Keys.E))
            {
                game.link.UseItem("bomb");
            }
            else if (userInput.IsKeyUp(Keys.W) || userInput.IsKeyUp(Keys.A) || userInput.IsKeyUp(Keys.S) || userInput.IsKeyUp(Keys.D))
            {
                game.link.direction = "idle";
            }
        }
    }
}