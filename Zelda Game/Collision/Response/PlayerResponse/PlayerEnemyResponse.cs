using System;
namespace Zelda_Game
{
    public class PlayerEnemyResponse
    {
        public static void PlayerEnemy(Link player, String direction)
        {
            if (direction == "left-right")
            {
                player.TakeDamage();
                for (int i=0; i<= 70; i++)
                {
                    if(player.position.X <= 59)
                    {
                        player.position.X = 59;
                    }
                    player.position.X--;
                }
                player.speed = 2;
                
            }
            if (direction == "right-left")
            {
                player.TakeDamage();
                for (int i = 0; i <= 70; i++)
                {
                    if (player.position.X >= 411)
                    {
                        player.position.X = 411;
                    }
                    player.position.X++;
                }
                player.speed = 2;
            }
            if (direction == "top-bottom")
            {
                player.TakeDamage();
                for (int i = 0; i <= 70; i++)
                {
                    if (player.position.Y >= 253)
                    {
                        player.position.Y = 253;
                    }
                    player.position.Y++;
                }
                player.speed = 2;
            }
            if (direction == "bottom-top")
            {
                player.TakeDamage();
                for (int i = 0; i <= 70; i++)
                {
                    if (player.position.Y <= 61)
                    {
                        player.position.Y = 61;
                    }
                    player.position.Y--;
                }
                player.speed = 2;
            }
        }
    }
}
