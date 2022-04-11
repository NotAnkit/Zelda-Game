using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerEnemyLoop
    {
        public static void EnemyLoop(Dictionary<Vector2, IEnemy> enemies, Link player, Dictionary<Vector2, IEnvironment> blocks, List<IDoor> doors, Game1 game)
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
                        projectile.Key.SetFinished(true);
                        enemy.Value.DecreaseHealth();
                    }
                }

                if (enemy.Value.Health() <= 0)
                {
                    deleteEnemy.Add(enemy.Key);
                }

                if(enemy.Value is Dragon | enemy.Value is Goriya)
                {
                    PlayerEnemyProjectileLoop.EnemyProjectileLoop(enemy.Value, player);
                }

            }

            foreach (Vector2 enemy in deleteEnemy)
            {
                enemies.Remove(enemy);
            }

            if (enemies.Count == 0)
            {
                if (game.manager.roomLocation.Key == 3 && game.manager.roomLocation.Value == 5)
                {
                    if(!game.manager.roomData.itemList.ContainsKey(new Vector2(200, 100)))
                    {
                        game.manager.roomData.itemList.Add(new Vector2(200, 100), ItemSpriteFactory.Instance.BowItem());
                    }
                    
                }

                foreach (IDoor door in doors.ToArray())
                {
                    if (door is LeftSealed)
                    {
                        doors.Insert(1, new LeftDoor(game));
                        doors.RemoveAt(2);
                    }
                    if (door is RightSealed)
                    {
                        doors.Insert(2, new RightDoor(game));
                        doors.RemoveAt(3);
                    }
                    if (door is TopSealed)
                    {
                        doors.Insert(0, new TopDoor(game));
                        doors.RemoveAt(1);
                    }
                    if (door is BottomSealed)
                    {
                        doors.Insert(3, new BottomDoor(game));
                        doors.RemoveAt(4);
                    }
                }

                
            }
        }
    }
}
