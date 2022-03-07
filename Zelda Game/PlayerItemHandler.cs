using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
namespace Zelda_Game
{
    public class PlayerItemHandler
    {
        public void PlayerItem(Game1 Game, String direction)
        {
            List<IItem> itemList;

            if (direction == "left-right")
            {
                if (Game.link.direction == "left" || Game.link.direction == "up" || Game.link.direction == "down")
                {
                    Game.link.speed = 2;
                }
                else
                {
                    Game.link.speed = 0;
                }
            }

            if (direction == "right-left")
            {
                if (Game.link.direction == "right" || Game.link.direction == "up" || Game.link.direction == "down")
                {
                    Game.link.speed = 2;
                }
                else
                {
                    Game.link.speed = 0;
                }

            }

            if (direction == "top-bottom")
            {
                if (Game.link.direction == "down" || Game.link.direction == "right" || Game.link.direction == "left")
                {
                    Game.link.speed = 2;
                }
                else
                {
                    Game.link.speed = 0;
                }

            }

            if (direction == "bottom-top")
            {
                if (Game.link.direction == "up" || Game.link.direction == "right" || Game.link.direction == "left")
                {
                    Game.link.speed = 2;
                }
                else
                {
                    Game.link.speed = 0;
                }

            }
        }    

    }   
}
