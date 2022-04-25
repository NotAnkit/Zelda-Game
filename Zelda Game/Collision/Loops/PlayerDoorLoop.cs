using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerDoorLoop
    {
        public static List<IDoor> PlayerLoop(Room room, Game1 game1, RoomManager manager)
        {
            List<IDoor> roomDoors = room.doorList;
            string direction;

            foreach (IDoor door in room.doorList.ToArray())
            {
                Rectangle linkRectangle = game1.link.LinkRectangle;
                Rectangle doorRectangle = door.DoorRectangle();
                direction = CollisionDetection.GetDirection(linkRectangle, doorRectangle);

                if (direction == "right-left")
                {
                    if (door is LeftDoor || door is LeftCave)
                    {
                        DoorResponse.DoorCaveResponse(door, game1, manager, room);                 
                    }
                    else if (door is LeftKey && game1.link.inventory.Keys > 0)
                    {
                        game1.link.inventory.Keys--;
                        game1.link.position.X += 16;
                        DoorKeyResponse.KeyDoorResponse(door, manager, game1, roomDoors);
                    }
                }
                else if (direction == "left-right")
                {
                    if (door is RightDoor || door is RightCave)
                    {
                        DoorResponse.DoorCaveResponse(door, game1, manager, room);
                    }
                    else if (door is RightKey && game1.link.inventory.Keys > 0)
                    {
                        game1.link.inventory.Keys--;
                        game1.link.position.X -= 16;
                        DoorKeyResponse.KeyDoorResponse(door, manager, game1, roomDoors);
                    }

                }
                else if (direction == "top-bottom")
                {
                    if (door is TopDoor || door is TopCave)
                    {
                        DoorResponse.DoorCaveResponse(door, game1, manager, room);
                    }
                    else if (door is TopKey && game1.link.inventory.Keys > 0)
                    {
                        game1.link.inventory.Keys--;
                        game1.link.position.Y += 16;
                        DoorKeyResponse.KeyDoorResponse(door, manager, game1, roomDoors);

                    }
                }
                else if (direction == "bottom-top")
                {
                    if (door is BottomDoor || door is BottomCave)
                    {
                        DoorResponse.DoorCaveResponse(door, game1, manager, room);
                    }
                    else if (door is BottomKey && game1.link.inventory.Keys > 0)
                    {
                        game1.link.inventory.Keys--;
                        game1.link.position.Y -= 16;
                        DoorKeyResponse.KeyDoorResponse(door, manager, game1, roomDoors);
                    }
                }
            }

            return roomDoors;
        }
    }
}
