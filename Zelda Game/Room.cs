using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zelda_Game
{
    public class Room
    {
        private readonly Dictionary<IEnvironment, Vector2> blockList;
        public Room(Level room, Game1 game1)
        {
            blockList = new Dictionary<IEnvironment, Vector2>();
            foreach (KeyValuePair<string, Vector2> block in room.Blocks)
            {
                if(block.Key.Equals("SB"))
                {
                    blockList.Add(new SquareBlock(game1), block.Value);
                }
                else if (block.Key.Equals("BLB"))
                {
                    blockList.Add(new BlackBlock(game1), block.Value);
                }
                else if (block.Key.Equals("BS"))
                {
                    blockList.Add(new BlueSand(game1), block.Value);
                }
                else if (block.Key.Equals("BB"))
                {
                    blockList.Add(new BrickBlock(game1), block.Value);
                }
                else if (block.Key.Equals("LB"))
                {
                    blockList.Add(new LadderBlock(game1), block.Value);
                }
                else if (block.Key.Equals("NBB"))
                {
                    blockList.Add(new NavyBlueBlock(game1), block.Value);
                }
                else if (block.Key.Equals("PB"))
                {
                    blockList.Add(new PushableBlock(game1), block.Value);
                }
                else if (block.Key.Equals("S"))
                {
                    blockList.Add(new Stairs(game1), block.Value);
                }
                else if (block.Key.Equals("S1"))
                {
                    blockList.Add(new Statue1(game1), block.Value);
                }
                else if (block.Key.Equals("S2"))
                {
                    blockList.Add(new Statue2(game1), block.Value);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (KeyValuePair<IEnvironment, Vector2> block in blockList)
            {
                block.Key.Draw(spriteBatch, block.Value);
            }
        }
    }
}
