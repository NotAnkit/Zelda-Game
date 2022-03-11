﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class Room
    {
        public readonly Dictionary<Vector2, IEnvironment> blockList;
        public Dictionary<Vector2, IEnemy> enemyList;
        public Dictionary<Vector2, IItem> itemList;
        private readonly List<IDoor> doorList;


        public Room(Level room, Game1 game1)
        {
            blockList = new Dictionary<Vector2, IEnvironment>();
            enemyList = new Dictionary<Vector2, IEnemy>();
            itemList = new Dictionary<Vector2, IItem>();
            doorList = new List<IDoor>();

            blockList = AddRoomBlocks.Instance.LoadBlocks(room.Blocks);
            enemyList = AddRoomEnemies.Instance.LoadEnemies(room.Enemies, game1);
            itemList = AddRoomItems.Instance.LoadItems(room.Items);

            for (int i = 0; i < room.Doors.Length; i++)
            {
                doorList = AddDoors.Instance.LoadDoors(doorList, room.Doors[i], game1);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            foreach (KeyValuePair<Vector2, IEnvironment> block in blockList)
            {
                block.Value.Draw(spriteBatch, block.Key);
            }
            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemyList)
            {
                enemy.Value.Draw(spriteBatch, enemy.Key);
            }
            foreach (KeyValuePair<Vector2, IItem> item in itemList)
            {
                item.Value.Draw(spriteBatch, item.Key);
            }
            foreach (IDoor door in doorList)
            {
                door.Draw(spriteBatch, new Vector2(100, 100));
            }
        }

        public void Update()
        {
            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemyList)
            {
                enemy.Value.Update();
            }
            foreach (KeyValuePair<Vector2, IItem> item in itemList)
            {
                item.Value.Update();
            }
        }
    }
}
