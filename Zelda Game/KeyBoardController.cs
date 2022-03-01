using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        private KeyboardState userInput;
        private Game1 game;
        public KeyBoardController(Game1 _game)
        {
            game = _game;
        }
        public void Update()
        {
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
            else if (userInput.IsKeyDown(Keys.W) || userInput.IsKeyDown(Keys.Up))
            {
                game.link.direction = "up";

            }
            else if (userInput.IsKeyDown(Keys.A) || userInput.IsKeyDown(Keys.Left))
            {
                game.link.direction = "left";

            }
            else if (userInput.IsKeyDown(Keys.S) || userInput.IsKeyDown(Keys.Down))
            {
                game.link.direction = "down";

            }
            else if (userInput.IsKeyDown(Keys.D) || userInput.IsKeyDown(Keys.Right))
            {
                game.link.direction = "right";

            }
            else if (userInput.IsKeyDown(Keys.Z) || userInput.IsKeyDown(Keys.N))
            {

                game.link.UseSword();


            }
            else if (userInput.IsKeyDown(Keys.E))
            {

                game.link.TakeDamage();


            }
            else if (userInput.IsKeyDown(Keys.D1))
            {

                game.link.UseItem("bomb");


            }
            else if (userInput.IsKeyDown(Keys.D2))
            {

                game.link.UseItem("blue-arrow");


            }
            else if (userInput.IsKeyDown(Keys.D3))
            {

                game.link.UseItem("green-arrow");


            }
            else if (userInput.IsKeyDown(Keys.D4))
            {

                game.link.UseItem("fire");


            }
            else if (userInput.IsKeyDown(Keys.D5))
            {

                game.link.UseItem("green-boomerang");


            }
            else if (userInput.IsKeyDown(Keys.D6))
            {

                game.link.UseItem("blue-boomerang");


            }
            else if (userInput.IsKeyUp(Keys.W) || userInput.IsKeyUp(Keys.A) || userInput.IsKeyUp(Keys.S) || userInput.IsKeyUp(Keys.D))
            {
                game.link.direction = "idle";
            }
        }
    }
}