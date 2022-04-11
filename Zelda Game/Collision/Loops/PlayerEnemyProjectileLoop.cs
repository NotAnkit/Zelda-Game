using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class PlayerEnemyProjectileLoop
    {
        public static void EnemyProjectileLoop(IEnemy enemy, Link player)
        {
            string direction;
                Rectangle linkRectangle = player.LinkRectangle;
                for (int i = 1; i < 4; i++)
                {
                    Rectangle enemyRectangle = enemy.ProjectileRectangle(i);
                    direction = CollisionDetection.GetDirection(linkRectangle, enemyRectangle);
                    PlayerEnemyProjectileResponse.PlayerEnemyProjectile(player, direction);
                }
        }
    }
}
