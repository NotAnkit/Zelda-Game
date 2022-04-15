using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerBlockResponse
    {
        public static void PlayerBlock(Link player, string[] directionLocked, List<string> collisonDirection, IEnvironment blockType, RoomManager manager)
        {
            if (blockType is PushableBlock)
            {
                for (int i = 0; i < collisonDirection.Count; i++)
                {
                    if (collisonDirection[i].Equals("top-bottom")) ((PushableBlock)blockType).position.Y -= 2;

                    else if (collisonDirection[i].Equals("bottom-top")) ((PushableBlock)blockType).position.Y += 2;

                    else if (collisonDirection[i].Equals("right-left")) ((PushableBlock)blockType).position.X -= 2;

                    else if (collisonDirection[i].Equals("left-right")) ((PushableBlock)blockType).position.X += 2;
                }
            }
            else if(blockType is BlueSand || blockType is BigBlackBlock)
            {

            }
            else if (blockType is Stairs)
            {
                for (int i = 0; i < collisonDirection.Count; i++)
                {
                    if (collisonDirection[i].Equals("left-right"))
                    {
                        player.position = new Vector2(100, 100);
                        //Sould to transition here
                        manager.roomLocation = new KeyValuePair<int, int>(1, 1);
                        manager.roomData = manager.roomList[manager.roomLocation];
                    }
                    else if (collisonDirection[i].Equals("top-bottom"))
                    {
                        player.position = new Vector2(221, 157);
                        //Sould to transition here
                        manager.roomLocation = new KeyValuePair<int, int>(1, 0);
                        manager.roomData = manager.roomList[manager.roomLocation];
                    }
                }
                
            }
            else
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
