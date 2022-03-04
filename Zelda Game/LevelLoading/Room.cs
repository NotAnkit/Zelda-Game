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
        private readonly List<IDoor> doorList;
        

        public Room(Level room, Game1 game1)
        {
            blockList = new Dictionary<Vector2, IEnvironment>();
            enemyList = new Dictionary<Vector2, IEnemy>();
            itemList = new Dictionary<Vector2, IItem>();
            doorList = new List<IDoor>();
            
            foreach(KeyValuePair<Vector2, string> block in room.Blocks)
            {
                if(block.Value.Equals("SB"))  blockList.Add(block.Key, new SquareBlock(game1, block.Key));

                else if (block.Value.Equals("BLB")) blockList.Add(block.Key, new BlackBlock(game1, block.Key));

                else if (block.Value.Equals("BS")) blockList.Add(block.Key, new BlueSand(game1, block.Key));

                else if (block.Value.Equals("BB")) blockList.Add(block.Key, new BrickBlock(game1, block.Key));

                else if (block.Value.Equals("LB")) blockList.Add(block.Key, new LadderBlock(game1, block.Key));

                else if (block.Value.Equals("NBB")) blockList.Add(block.Key, new NavyBlueBlock(game1, block.Key));

                else if (block.Value.Equals("PB")) blockList.Add(block.Key, new PushableBlock(game1, block.Key));

                else if (block.Value.Equals("S")) blockList.Add(block.Key, new Stairs(game1, block.Key));

                else if (block.Value.Equals("S1")) blockList.Add(block.Key, new Statue1(game1, block.Key));

                else if (block.Value.Equals("S2")) blockList.Add(block.Key, new Statue2(game1, block.Key));

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

            for(int i = 0; i<room.Doors.Length; i++)
            {
                if(room.Doors[i].Equals("TopWall"))
                {
                    doorList.Add(new TopWall(game1));
                }
                else if (room.Doors[i].Equals("TopDoor"))
                {
                    doorList.Add(new TopDoor(game1));
                }
                else if (room.Doors[i].Equals("TopKey"))
                {
                    doorList.Add(new TopKey(game1));
                }
                else if (room.Doors[i].Equals("TopSealed"))
                {
                    doorList.Add(new TopSealed(game1));
                }
                else if (room.Doors[i].Equals("TopCave"))
                {
                    doorList.Add(new TopCave(game1));
                }

                if (room.Doors[i].Equals("LeftWall"))
                {
                    doorList.Add(new LeftWall(game1));
                }
                else if (room.Doors[i].Equals("LeftDoor"))
                {
                    doorList.Add(new LeftDoor(game1));
                }
                else if (room.Doors[i].Equals("LeftKey"))
                {
                    doorList.Add(new LeftKey(game1));
                }
                else if (room.Doors[i].Equals("LeftSealed"))
                {
                    doorList.Add(new LeftSealed(game1));
                }
                else if (room.Doors[i].Equals("LeftCave"))
                {
                    doorList.Add(new LeftCave(game1));
                }

                if (room.Doors[i].Equals("RightWall"))
                {
                    doorList.Add(new RightWall(game1));
                }
                else if (room.Doors[i].Equals("RightDoor"))
                {
                    doorList.Add(new RightDoor(game1));
                }
                else if (room.Doors[i].Equals("RightKey"))
                {
                    doorList.Add(new RightKey(game1));
                }
                else if (room.Doors[i].Equals("RightSealed"))
                {
                    doorList.Add(new RightSealed(game1));
                }
                else if (room.Doors[i].Equals("RightCave"))
                {
                    doorList.Add(new RightCave(game1));
                }

                if (room.Doors[i].Equals("BottomWall"))
                {
                    doorList.Add(new BottomWall(game1));
                }
                else if (room.Doors[i].Equals("BottomDoor"))
                {
                    doorList.Add(new BottomDoor(game1));
                }
                else if (room.Doors[i].Equals("BottomKey"))
                {
                    doorList.Add(new BottomKey(game1));
                }
                else if (room.Doors[i].Equals("BottomSealed"))
                {
                    doorList.Add(new BottomSealed(game1));
                }
                else if (room.Doors[i].Equals("BottomCave"))
                {
                    doorList.Add(new BottomCave(game1));
                }
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
            foreach(IDoor door in doorList)
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
