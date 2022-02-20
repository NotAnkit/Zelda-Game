using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        private KeyboardState userInput;
        private KeyboardState previousState;
        private KeyboardState currentState;
        private Game1 game;
        //private List<IEnvironment> List;
        private List<IItem> List2; 
        //public int i = 0;
        public int j = 0;
        public KeyBoardController(Game1 _game, List<IItem> itemList)
        {
            game = _game;
            //List = blockList;
            List2 = itemList;

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

                 game.link.useSword();
                
                
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
            else if(userInput.IsKeyUp(Keys.W) || userInput.IsKeyUp(Keys.A) || userInput.IsKeyUp(Keys.S) || userInput.IsKeyUp(Keys.D))
            {
                game.link.direction = "idle";
            }
            previousState = currentState;
            currentState = Keyboard.GetState();
            //if (userInput.IsKeyDown(Keys.T) && !previousState.IsKeyDown(Keys.T))
            //{
            //    i++;
            //    if(i>9)
            //    {
            //        i = 0;
            //    }
            //    game.enviornment = List[i];

            //}
            //if (userInput.IsKeyDown(Keys.Y) && !previousState.IsKeyDown(Keys.Y))
            //{
            //    i--;
            //    if(i<0)
            //    {
            //        i = 9;
            //    }
            //    game.enviornment = List[i];
            //}

            //item list

            if (userInput.IsKeyDown(Keys.U) && !previousState.IsKeyDown(Keys.U))
            {
                j++;
                if (j > 11)
                {
                    j = 0;
                }
                game.item = List2[j];

            }
            else if (userInput.IsKeyDown(Keys.I) && !previousState.IsKeyDown(Keys.I))
            {
                j--;
                if (j < 0)
                {
                    j = 11;
                }
                game.item = List2[j];
            }

          
        }
    }
}
