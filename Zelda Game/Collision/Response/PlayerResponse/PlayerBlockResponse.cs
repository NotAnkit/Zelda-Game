using System.Collections.Generic;
namespace Zelda_Game
{
    public static class PlayerBlockResponse
    {
        public static void PlayerBlock(Link player, string[] directionLocked, List<string> collisonDirection, IEnvironment blockType)
        {
            if (blockType is PushableBlock)
            {
                //PushableBlock block = blockType as PushableBlock;
                //block.position.Y -= 2;
            }

            if (!(blockType is BlueSand))
            {
                for (int i = 0; i < collisonDirection.Count; i++)
                {
                    if (collisonDirection[i].Equals("top-bottom")) directionLocked[i] = "up";

                    else if (collisonDirection[i].Equals("bottom-top")) directionLocked[i] = "down";

                    else if (collisonDirection[i].Equals("right-left")) directionLocked[i] = "left";

                    else if (collisonDirection[i].Equals("left-right")) directionLocked[i] = "right";
                }

                if (player.direction == directionLocked[0] || player.direction == directionLocked[1] || player.direction == directionLocked[2])  player.speed = 0;

                else  player.speed = 2;
            }

            
        }
    }
}
