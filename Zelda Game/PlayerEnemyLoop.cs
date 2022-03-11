using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerEnemyLoop
    {
        public static void EnemyLoop(Dictionary<Vector2, IEnemy> enemies, Link player, Dictionary<Vector2, IEnvironment> blocks)
        {
            string direction;
            List<Vector2> deleteEnemy = new List<Vector2>();

            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemies)
            {
                Rectangle linkRectangle = player.LinkRectangle;
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, enemyRectangle);
                foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                {
                    PlayerEnemyResponse.PlayerEnemy(player, direction, block.Value);
                }

                foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                {
                    Rectangle blockRectangle = block.Value.blockRectangle();
                    direction = CollisionDetection.getDirection(enemyRectangle, blockRectangle);
                    if (direction != "none")
                    {
                        EnemyBlockResponse.EnemyBlock(direction, enemy.Value);
                    }
                }

                foreach (KeyValuePair<IProjectile, Vector2> projectile in player.items)
                {
                    Rectangle blockRectangle = projectile.Key.ProjectileRectangle();
                    direction = CollisionDetection.getDirection(enemyRectangle, blockRectangle);
                    if (direction != "none")
                    {
                        deleteEnemy.Add(enemy.Key);
                    }
                }

            }

            foreach (Vector2 enemy in deleteEnemy)
            {
                enemies.Remove(enemy);
            }
        }
    }
}
