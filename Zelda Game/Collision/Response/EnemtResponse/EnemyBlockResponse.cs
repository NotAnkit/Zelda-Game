using System;
using System.Collections.Generic;
using System.Drawing;

namespace Zelda_Game
{
    public static class EnemyBlockResponse
    {
        public static void EnemyBlock(Game1 Game, string[] directionLocked, List<string> collisonDirection)
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

                /*if (Game.enemy.GetDirection() == (directionLocked[0]) || Game.enemy.GetDirection() == directionLocked[1] || Game.enemy.GetDirection() == directionLocked[2])
                {
                    Game.enemy.SetSpeed(0f);
                }
                else
                {
                    Game.enemy.SetSpeed(1f);
                }*/
            }
        }
    }
}
