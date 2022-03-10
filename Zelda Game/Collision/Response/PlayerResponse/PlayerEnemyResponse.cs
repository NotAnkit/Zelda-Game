using System;
namespace Zelda_Game
{
    public class PlayerEnemyResponse
    {
        public static void PlayerEnemy(Game1 Game, String direction)
        {
            if (direction == "left-right")
            {
                Game.link.TakeDamage();
                for (int i=0; i<= 70; i++)
                {
                    if(Game.link.position.X <= 59)
                    {
                        Game.link.position.X = 59;
                    }
                    Game.link.position.X--;
                }
                Game.link.speed = 2;
                
            }
            if (direction == "right-left")
            {
                Game.link.TakeDamage();
                for (int i = 0; i <= 70; i++)
                {
                    if (Game.link.position.X >= 411)
                    {
                        Game.link.position.X = 411;
                    }
                    Game.link.position.X++;
                }
                Game.link.speed = 2;
            }
            if (direction == "top-bottom")
            {
                Game.link.TakeDamage();
                for (int i = 0; i <= 70; i++)
                {
                    if (Game.link.position.Y >= 253)
                    {
                        Game.link.position.Y = 253;
                    }
                    Game.link.position.Y++;
                }
                Game.link.speed = 2;
            }
            if (direction == "bottom-top")
            {
                Game.link.TakeDamage();
                for (int i = 0; i <= 70; i++)
                {
                    if (Game.link.position.Y <= 61)
                    {
                        Game.link.position.Y = 61;
                    }
                    Game.link.position.Y--;
                }
                Game.link.speed = 2;
            }
        }
    }
}
