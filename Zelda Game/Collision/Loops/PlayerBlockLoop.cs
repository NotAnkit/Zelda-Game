using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerBlockLoop
    {
        public static void BlockLoop(Dictionary<Vector2, IEnvironment> blocks, Link player)
        {
            List<string> collisonDirection = new List<string>();
            string[] directionLocked = new string[3];
            string direction;
            directionLocked[0] = "none";
            directionLocked[1] = "none";
            directionLocked[2] = "none";

            foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
            {
                Rectangle linkRectangle = player.LinkRectangle;
                Rectangle blockRectangle = block.Value.BlockRectangle();
                direction = CollisionDetection.GetDirection(linkRectangle, blockRectangle);
                if (direction != "none" && !(block.Value is PushableBlock))
                {
                    collisonDirection.Add(direction);
                }
                PlayerBlockResponse.PlayerBlock(player, directionLocked, collisonDirection, block.Value);
            }
        }
    }
}
