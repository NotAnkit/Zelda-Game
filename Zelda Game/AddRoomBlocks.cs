using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class AddRoomBlocks
    {
        private static AddRoomBlocks instance = new AddRoomBlocks();

        public static AddRoomBlocks Instance
        {
            get
            {
                return instance;
            }
        }
        private AddRoomBlocks()
        {

        }

        public Dictionary<Vector2, IEnvironment> LoadBlocks(Dictionary<Vector2, String> roomBlocks, Game1 game1)
        {
            Dictionary<Vector2, IEnvironment> blockList = new Dictionary<Vector2, IEnvironment>();

            foreach (KeyValuePair<Vector2, string> block in roomBlocks)
            {
                if (block.Value.Equals("SB")) blockList.Add(block.Key, new SquareBlock(game1, block.Key));

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

            return blockList;
        }
    }
}