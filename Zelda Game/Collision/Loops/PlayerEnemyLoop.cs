using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerEnemyLoop
    {
        public static void EnemyLoop(Dictionary<Vector2, IEnemy> enemies, Link player, Dictionary<Vector2, IEnvironment> blocks)
        {
            List<Vector2> deleteEnemy = new List<Vector2>();
            string direction;

            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemies)
            {
                Rectangle linkRectangle = player.LinkRectangle;
                Rectangle enemyRectangle = enemy.Value.EnemyRectangle();
                direction = CollisionDetection.GetDirection(linkRectangle, enemyRectangle);
                List<string> collisonDirection = new List<string>();
                string[] directionLocked = new string[4];
                directionLocked[0] = "none";
                directionLocked[1] = "none";
                directionLocked[2] = "none";

                PlayerEnemyResponse.PlayerEnemy(player, direction, enemy.Value);
                

                foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                {
                    Rectangle blockRectangle = block.Value.BlockRectangle();
                    direction = CollisionDetection.GetDirection(enemyRectangle, blockRectangle);
                    if (direction != "none")
                    {
                        collisonDirection.Add(direction);  
                    }
                    EnemyBlockResponse.EnemyBlock(enemy.Value, directionLocked, collisonDirection);
                }
                

                foreach (KeyValuePair<IProjectile, Vector2> projectile in player.items)
                {
                    Rectangle blockRectangle = projectile.Key.ProjectileRectangle();
                    direction = CollisionDetection.GetDirection(enemyRectangle, blockRectangle);
                    if (direction != "none")
                    {
                        enemy.Value.DecreaseHealth();
                    }
                }

                if (enemy.Value.Health() <= 0)
                {
                    deleteEnemy.Add(enemy.Key);
                }

            }

            foreach (Vector2 enemy in deleteEnemy)
            {
                enemies.Remove(enemy);
            }
        }
    }
}
