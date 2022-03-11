using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerEnemyLoop
    {
        public static void EnemyLoop(Dictionary<Vector2, IEnemy> enemies, Link player, Dictionary<Vector2, IEnvironment> blocks)
        {
            List<Vector2> deleteEnemy = new List<Vector2>();
            String direction;

            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemies)
            {
                Rectangle linkRectangle = player.LinkRectangle;
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, enemyRectangle);
                List<string> collisonDirection = new List<string>();
                string[] directionLocked = new string[4];
                directionLocked[0] = "none";
                directionLocked[1] = "none";
                directionLocked[2] = "none";
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
                        collisonDirection.Add(direction);  
                    }
                    EnemyBlockResponse.EnemyBlock(enemy.Value, directionLocked, collisonDirection);
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
