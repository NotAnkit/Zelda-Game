﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;

        private List<Vector2> deleteEnemy;

        public Collision(Game1 game)
        {
            Game = game;
            deleteEnemy = new List<Vector2>();
        }

        public void Collide(Room room)
        {
            PlayerEnemyLoop.EnemyLoop(room.enemyList, Game.link, room.blockList);

            PlayerBlockLoop.BlockLoop(room.blockList, Game.link);

            room.itemList = ItemResponseLoop.ItemLoop(room.itemList, Game.link);

            //Player Door Collision
            foreach (IDoor door in room.doorList)
            {
                //to do
            }

        }
    }
}
