using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        KeyboardState userInput;
        private Game1 game;
        private List<IEnvironment> List;
        private List<IItem> List2; 
        public int i = 60;
        public KeyBoardController(Game1 _game, List<IEnvironment> blockList, List<IItem> itemList)
        {
            game = _game;
            List = blockList;
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
                //
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
                game.link.direction = "down";
               
            }
            else if (userInput.IsKeyDown(Keys.D) || userInput.IsKeyDown(Keys.NumPad4))
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

                game.link.UseItem("boomerang");


            }
            else if(userInput.IsKeyUp(Keys.W) || userInput.IsKeyUp(Keys.A) || userInput.IsKeyUp(Keys.S) || userInput.IsKeyUp(Keys.D))
            {
                game.link.direction = "idle";
            }
            
            if (userInput.IsKeyDown(Keys.T))
            {
                i++;
                if(i>9)
                {
                    i = 0;
                }
                game.enviornment = List[i];

            }
            if (userInput.IsKeyDown(Keys.Y))
            {
                i--;
                if(i<0)
                {
                    i = 9;
                }
                game.enviornment = List[i];
            }

            //item list

            if (userInput.IsKeyDown(Keys.U))
            {
                i++;
                if (i > 11)
                {
                    i = 0;
                }
                game.item = List2[i];

            }
            else if (userInput.IsKeyDown(Keys.I))
            {
                i--;
                if (i < 0)
                {
                    i = 11;
                }
                game.item = List2[i];
            }

          
        }
    }
}
