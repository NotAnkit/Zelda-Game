using System;
using System.Collections.Generic;
using System.Drawing;

namespace Zelda_Game
{
    public static class EnemyBlockResponse
    {
        public static void EnemyBlock(string collisonDirection, IEnemy enemy)
        {

            string directionLocked;
            if (collisonDirection.Equals("top-bottom"))
            {
                directionLocked = "down";
            }
            else if (collisonDirection.Equals("bottom-top"))
            {
                directionLocked = "up";
            }
            else if (collisonDirection.Equals("right-left"))
            {
                directionLocked = "left";
            }
            else
            {
                directionLocked = "right";
            } 

            if (enemy.GetDirection().Equals(directionLocked))
            {
                enemy.SetSpeed(0f);
            }
            else
            {
                enemy.SetSpeed(1f);
            }
        }
    }
}
