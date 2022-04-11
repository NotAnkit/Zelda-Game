using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class PlayerEnemyProjectileLoop
    {
        public PlayerEnemyProjectileLoop(Dictionary<Vector2, IEnemyProjectile> projectiles, Link player)
        {
            string direction;
            foreach (KeyValuePair<Vector2, IEnemyProjectile> projectile in projectiles)
            {
                Rectangle linkRectangle = player.LinkRectangle;
                for (int i = 1; i < 4; i++)
                {
                    Rectangle enemyRectangle = projectile.Value.EnemyRectangle(i);
                    direction = CollisionDetection.GetDirection(linkRectangle, enemyRectangle);
                    PlayerEnemyProjectileResponse.PlayerEnemyProjectile(player, direction);
                }
            }
        }
    }
}
