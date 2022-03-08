using System;
using System.Drawing;

namespace Zelda_Game
{
    public static class EnemyBlockResponse
    {
        public static void EnemyBlock(Game1 Game, String direction)
        {
            if (direction == "left-right")
            {
                Game.enemy.SetSpeed(0);
                //Game.enemy.position.X = ;
                for (int i = 0; i <= 50; i++)
                {
                    //Game.enemy.position.X--;
                }
            }

            if (direction == "right-left")
            {
                if (Game.link.direction == "right" || Game.link.direction == "up" || Game.link.direction == "down")
                {
                    Game.enemy.SetSpeed(1);
                }
                else
                {
                    Game.enemy.SetSpeed(0);
                }

            }

            if (direction == "top-bottom")
            {
                if (Game.link.direction == "down" || Game.link.direction == "right" || Game.link.direction == "left")
                {
                    Game.enemy.SetSpeed(1);
                }
                else
                {
                    Game.enemy.SetSpeed(0);
                }

            }

            if (direction == "bottom-top")
            {
                if (Game.link.direction == "up" || Game.link.direction == "right" || Game.link.direction == "left")
                {
                    Game.enemy.SetSpeed(1);
                }
                else
                {
                    Game.enemy.SetSpeed(0);
                }

            }
        }
    }
}
