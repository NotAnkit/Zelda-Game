using System;
namespace Zelda_Game
{
    public class PlayerEnemyProjectileResponse
    {
        public static void PlayerEnemyProjectile(Link player, string direction, IEnemyProjectile projectile)
        {
            if(direction != "none")
            {
                player.TakeDamage();
            }
        }
    }
}
