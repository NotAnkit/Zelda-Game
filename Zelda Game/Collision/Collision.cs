using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;
        private List<string> collisonDirection;
        private string[] directionLocked;

        private List<string> collisionDirectionEnemy;
        private string[] directionLockedEnemy;
        private List<Vector2> deleteItem;
        private List<Vector2> deleteEnemy;

        public Collision(Game1 game)
        {
            Game = game;
            collisonDirection = new List<string>();
            directionLocked = new string[8];
            deleteItem = new List<Vector2>();
            deleteEnemy = new List<Vector2>();

            collisionDirectionEnemy = new List<string>();
            directionLockedEnemy = new string[8];

        }

        public void Collide(Room room)
        {
            String direction;
            directionLocked[0] = "none";
            directionLocked[1] = "none";
            directionLocked[2] = "none";
            collisonDirection = new List<string>();

            directionLockedEnemy[0] = "none";
            directionLockedEnemy[1] = "none";
            directionLockedEnemy[2] = "none";
            collisionDirectionEnemy = new List<string>();

            //Enemy Player Collision
            foreach (KeyValuePair<Vector2, IEnemy> enemy in room.enemyList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, enemyRectangle);
                PlayerEnemyResponse.PlayerEnemy(Game, direction);

            }

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
                        collisionDirectionEnemy.Add(direction);
                    }
                    //EnemyBlockResponse.EnemyBlock(Game, directionLocked, collisonDirection);
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
