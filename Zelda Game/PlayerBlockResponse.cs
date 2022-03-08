﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
namespace Zelda_Game
{
    public static class PlayerBlockResponse
    {
        public static void PlayerBlock(Game1 Game, string[] directionLocked, List<string> collisonDirection, IEnvironment blockType)
        {
            if (!(blockType is BlueSand))
            {
                for (int i = 0; i < collisonDirection.Count; i++)
                {
                    if (collisonDirection[i].Equals("top-bottom"))
                    {
                        directionLocked[i] = "up";
                    }
                    else if (collisonDirection[i].Equals("bottom-top"))
                    {
                        directionLocked[i] = "down";
                    }
                    else if (collisonDirection[i].Equals("right-left"))
                    {
                        directionLocked[i] = "left";
                    }
                    else if (collisonDirection[i].Equals("left-right"))
                    {
                        directionLocked[i] = "right";
                    }
                }
                if (Game.link.direction == directionLocked[0] || Game.link.direction == directionLocked[1] || Game.link.direction == directionLocked[2])
                {
                    Game.link.speed = 0;
                }
                else
                {
                    Game.link.speed = 2;
                }
            }
        }
    }
}
