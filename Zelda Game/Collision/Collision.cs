using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;

        private string[] directionLockedEnemy;
        private List<Vector2> deleteEnemy;

        public Collision(Game1 game)
        {
            Game = game;
            deleteEnemy = new List<Vector2>();
            directionLockedEnemy = new string[8];
        }

        public void Collide(Room room)
        {
            String direction;

            directionLockedEnemy[0] = "none";
            directionLockedEnemy[1] = "none";
            directionLockedEnemy[2] = "none";

            //Enemy Block Collision
            //enemies can't run through blocks
            foreach (KeyValuePair<Vector2, IEnemy> enemy in room.enemyList)
            {
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                foreach (KeyValuePair<Vector2, IEnvironment> block in room.blockList)
                {
                    Rectangle blockRectangle = block.Value.blockRectangle();
                    direction = CollisionDetection.getDirection(enemyRectangle, blockRectangle);
                    if (direction != "none")
                    {
                        EnemyBlockResponse.EnemyBlock(Game, direction, enemy.Value);
                    }
                }

                foreach (KeyValuePair<IProjectile, Vector2> projectile in Game.link.items)
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
                room.enemyList.Remove(enemy);
            }

            PlayerEnemyLoop.EnemyLoop(room.enemyList, Game.link);

            PlayerBlockLoop.BlockLoop(room.blockList, Game.link);

            room.itemList = ItemResponseLoop.ItemLoop(room.itemList, Game.link);

            //Player Door Collision
            foreach (KeyValuePair<Vector2, IItem> item in room.itemList)
            {
                //to do
            }

        }
    }
}
