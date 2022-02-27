using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zelda_Game
{
    public class Room
    {
        private readonly Dictionary<Vector2, IEnvironment> blockList;
        public Room(Level room, Game1 game1)
        {
            blockList = new Dictionary<Vector2, IEnvironment>();
            foreach (KeyValuePair<Vector2, string> block in room.Blocks)
            {
                if(block.Key.Equals("SB"))
                {
                    blockList.Add(block.Key, new SquareBlock(game1));
                }
                else if (block.Key.Equals("BLB"))
                {
                    blockList.Add(block.Key, new BlackBlock(game1));
                }
                else if (block.Key.Equals("BS"))
                {
                    blockList.Add(block.Key, new BlueSand(game1));
                }
                else if (block.Key.Equals("BB"))
                {
                    blockList.Add(block.Key, new BrickBlock(game1));
                }
                else if (block.Key.Equals("LB"))
                {
                    blockList.Add(block.Key, new LadderBlock(game1));
                }
                else if (block.Key.Equals("NBB"))
                {
                    blockList.Add(block.Key, new NavyBlueBlock(game1));
                }
                else if (block.Key.Equals("PB"))
                {
                    blockList.Add(block.Key, new PushableBlock(game1));
                }
                else if (block.Key.Equals("S"))
                {
                    blockList.Add(block.Key, new Stairs(game1));
                }
                else if (block.Key.Equals("S1"))
                {
                    blockList.Add(block.Key, new Statue1(game1));
                }
                else if (block.Key.Equals("S2"))
                {
                    blockList.Add(block.Key, new Statue2(game1));
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (KeyValuePair<Vector2, IEnvironment> block in blockList)
            {
                block.Value.Draw(spriteBatch, block.Key);
            }
        }
    }
}
