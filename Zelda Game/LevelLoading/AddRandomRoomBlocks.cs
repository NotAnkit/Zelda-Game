using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class AddRandomRoomBlocks
    {
        private static readonly AddRandomRoomBlocks instance = new AddRandomRoomBlocks();

        public static AddRandomRoomBlocks Instance => instance;

        private AddRandomRoomBlocks()
        {

        }

        public Dictionary<Vector2, IEnvironment> LoadBlocks()
        {
            Dictionary<Vector2, IEnvironment> blockList = new Dictionary<Vector2, IEnvironment>();
            int value = 0;
            Random r = new Random();
            int i = r.Next(5, 10);
            Vector2 location = new Vector2(59, 61);

            while (i > 0)
            {
                
                value = r.Next(1, 7);
                location.X = (r.Next(1, 10) * 32) + 59;
                location.Y = (r.Next(1, 6) * 32) + 61;

                if (!blockList.ContainsKey(location))
                {

                    if (value == 1) blockList.Add(location, BlockSpriteFactory.Instance.SquareBlock());

                    else if (value == 2) blockList.Add(location, BlockSpriteFactory.Instance.BlackBlock());

                    else if (value == 3) blockList.Add(location, BlockSpriteFactory.Instance.BlueSand());

                    else if (value == 4) blockList.Add(location, BlockSpriteFactory.Instance.NavyBlueBlock());

                    else if (value == 5) blockList.Add(location, BlockSpriteFactory.Instance.Statue1());

                    else if (value == 6) blockList.Add(location, BlockSpriteFactory.Instance.Statue2());

                    i--;
                }

            }

            return blockList;
        }
    }
}