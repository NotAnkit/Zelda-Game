using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;

        public Collision(Game1 game)
        {
            Game = game;
        }

        public void Collide(Room room)
        {
            String direction;
            
            //when player runs into enemy, player should get pushed back
            foreach (KeyValuePair<Vector2, IEnemy> enemy in room.enemyList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, enemyRectangle);
                PlayerEnemyResponse.PlayerEnemy(Game, direction);
            }

            //enemies loop through blocks, enemy can't run through blocks
            foreach (KeyValuePair<Vector2, IEnemy> enemy in room.enemyList)
            {
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                foreach (KeyValuePair<Vector2, IEnvironment> block in room.blockList)
                {
                    Rectangle blockRectangle = block.Value.blockRectangle();
                    direction = CollisionDetection.getDirection(enemyRectangle, blockRectangle);
                    //EnemyBlockResponse.EnemyBlock(Game, direction);
                }
                
            }

            //player can't run through blocks
            foreach (KeyValuePair<Vector2, IEnvironment> block in room.blockList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle blockRectangle = block.Value.blockRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, blockRectangle);
                PlayerBlockResponse.PlayerBlock(Game, direction, block.Value);
            }

            //player collects items, items disappear when player touches item
            foreach (KeyValuePair<Vector2, IItem> item in room.itemList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle itemRectangle = item.Value.itemRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, itemRectangle);
                PlayerItemResponse.PlayerItem(Game, direction);
            }

            //player can go through doors to other rooms
            foreach (KeyValuePair<Vector2, IItem> item in room.itemList)
            {
                //to do
            }


            //player loop through items
            //call response method here
        }
    }
}
