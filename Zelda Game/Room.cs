using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class Room
    {
        private readonly Dictionary<Vector2, IEnvironment> blockList;
        private readonly Dictionary<Vector2, IEnemy> enemyList;
        private readonly Floor floor;

        public Room(Level room, Game1 game1)
        {
            blockList = new Dictionary<Vector2, IEnvironment>();
            enemyList = new Dictionary<Vector2, IEnemy>();
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
        }

        public void Update()
        {
            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemyList)
            {
                enemy.Value.Update();
            }
        }
    }
}
