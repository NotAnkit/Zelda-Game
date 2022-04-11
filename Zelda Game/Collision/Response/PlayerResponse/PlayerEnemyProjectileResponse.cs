using System;
namespace Zelda_Game
{
    public class PlayerEnemyProjectileResponse
    {
        public static void PlayerEnemyProjectile(Link player, string direction)
        {
            if(direction != "none")
            {
                player.TakeDamage();
            }
        }
    }
}
