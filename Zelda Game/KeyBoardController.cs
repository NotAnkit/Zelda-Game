﻿using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        KeyboardState userInput;
        private Game1 game;
        public KeyBoardController(Game1 _game)
        {
            game = _game;
        }
        public void Update()
        {
            userInput = Keyboard.GetState();
            if (userInput.IsKeyDown(Keys.D0) || userInput.IsKeyDown(Keys.NumPad0))
            {

            }
            else if (userInput.IsKeyDown(Keys.W) || userInput.IsKeyDown(Keys.NumPad1))
            {
                game.link.direction = "up";
            }
            else if (userInput.IsKeyDown(Keys.A) || userInput.IsKeyDown(Keys.NumPad2))
            {
                game.link.direction = "left";
            }
            else if (userInput.IsKeyDown(Keys.S) || userInput.IsKeyDown(Keys.NumPad3))
            {
                game.link.direction = "right";
            }
            else if (userInput.IsKeyDown(Keys.D) || userInput.IsKeyDown(Keys.NumPad4))
            {
                game.link.direction = "down";
            }
            else if (userInput.IsKeyDown(Keys.T))
            {
                game.enviornment = new SquareBlock(game);
            }
        }
    }
}
