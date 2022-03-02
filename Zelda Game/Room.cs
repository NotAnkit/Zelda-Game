using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class Room
    {
        private readonly Dictionary<Vector2, IEnvironment> blockList;
        private readonly Dictionary<Vector2, IEnemy> enemyList;
        private readonly Dictionary<Vector2, IItem> itemList;
        private readonly Floor floor;

        public Room(Level room, Game1 game1)
        {
            blockList = new Dictionary<Vector2, IEnvironment>();
            enemyList = new Dictionary<Vector2, IEnemy>();
            itemList = new Dictionary<Vector2, IItem>();
            floor = new Floor(game1);
            foreach(KeyValuePair<Vector2, string> block in room.Blocks)
            {
                if(block.Value.Equals("SB"))  blockList.Add(block.Key, new SquareBlock(game1));

                else if (block.Value.Equals("BLB")) blockList.Add(block.Key, new BlackBlock(game1));

                else if (block.Value.Equals("BS")) blockList.Add(block.Key, new BlueSand(game1));

                else if (block.Value.Equals("BB")) blockList.Add(block.Key, new BrickBlock(game1));

                else if (block.Value.Equals("LB")) blockList.Add(block.Key, new LadderBlock(game1));

                else if (block.Value.Equals("NBB")) blockList.Add(block.Key, new NavyBlueBlock(game1));

                else if (block.Value.Equals("PB")) blockList.Add(block.Key, new PushableBlock(game1));

                else if (block.Value.Equals("S")) blockList.Add(block.Key, new Stairs(game1));

                else if (block.Value.Equals("S1")) blockList.Add(block.Key, new Statue1(game1));

                else if (block.Value.Equals("S2")) blockList.Add(block.Key, new Statue2(game1));

            }

            foreach (KeyValuePair<Vector2, string> enemy in room.Enemies)
            {
                if (enemy.Value.Equals("J")) enemyList.Add(enemy.Key, new Jelly(game1, enemy.Key));

                else if (enemy.Value.Equals("B")) enemyList.Add(enemy.Key, new Bat(game1, enemy.Key));

                else if (enemy.Value.Equals("D")) enemyList.Add(enemy.Key, new Dragon(game1, enemy.Key));

                else if (enemy.Value.Equals("G")) enemyList.Add(enemy.Key, new Goriya(game1, enemy.Key));

                else if (enemy.Value.Equals("H")) enemyList.Add(enemy.Key, new Hand(game1, enemy.Key));

                else if (enemy.Value.Equals("S")) enemyList.Add(enemy.Key, new Stalfos(game1, enemy.Key));
            }
            foreach(KeyValuePair<Vector2, string> item in room.Items)
            {
                if (item.Value.Equals("A")) itemList.Add(item.Key, new ArrowItem(game1));

                else if (item.Value.Equals("BB")) itemList.Add(item.Key, new BombItem(game1));

                else if (item.Value.Equals("B")) itemList.Add(item.Key, new BowItem(game1));

                else if (item.Value.Equals("C")) itemList.Add(item.Key, new ClockItem(game1));

                else if (item.Value.Equals("CM")) itemList.Add(item.Key, new CompassItem(game1));

                else if (item.Value.Equals("F")) itemList.Add(item.Key, new FairyItem(game1));

                else if (item.Value.Equals("HC")) itemList.Add(item.Key, new HeartContainerItem(game1));

                else if (item.Value.Equals("H")) itemList.Add(item.Key, new HeartItem(game1));

                else if (item.Value.Equals("K")) itemList.Add(item.Key, new KeyItem(game1));

                else if (item.Value.Equals("M")) itemList.Add(item.Key, new MapItem(game1));

                else if (item.Value.Equals("R")) itemList.Add(item.Key, new RupeeItem(game1));

                else if (item.Value.Equals("T")) itemList.Add(item.Key, new TriforcePieceItem(game1));
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            floor.Draw(spriteBatch, new Vector2(100, 100));
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
