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
                if (block.Value.Equals("SB")) blockList.Add(block.Key, BlockSpriteFactory.Instance.SquareBlock());

                else if (block.Value.Equals("BLB")) blockList.Add(block.Key, BlockSpriteFactory.Instance.BlackBlock());

                else if (block.Value.Equals("BS")) blockList.Add(block.Key, BlockSpriteFactory.Instance.BlueSand());

                else if (block.Value.Equals("BB")) blockList.Add(block.Key, BlockSpriteFactory.Instance.BrickBlock());

                else if (block.Value.Equals("LB")) blockList.Add(block.Key, BlockSpriteFactory.Instance.LadderBlock());

                else if (block.Value.Equals("NBB")) blockList.Add(block.Key, BlockSpriteFactory.Instance.NavyBlueBlock());

                else if (block.Value.Equals("PB")) blockList.Add(block.Key, BlockSpriteFactory.Instance.PushableBlock());

                else if (block.Value.Equals("S")) blockList.Add(block.Key, BlockSpriteFactory.Instance.Stairs());

                else if (block.Value.Equals("S1")) blockList.Add(block.Key, BlockSpriteFactory.Instance.Statue1());

                else if (block.Value.Equals("S2")) blockList.Add(block.Key, BlockSpriteFactory.Instance.Statue2());

            }

            return blockList;
        }
    }
}