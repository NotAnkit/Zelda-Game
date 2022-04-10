﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerDoorLoop
    {
        public static List<IDoor> PlayerLoop(Room room, Game1 game1, RoomManager manager)
        {
            List<IDoor> roomDoors = room.doorList;
            string direction;
            Vector2 position;

            foreach (IDoor door in room.doorList.ToArray())
            {
                Rectangle linkRectangle = game1.link.LinkRectangle;
                Rectangle doorRectangle = door.DoorRectangle();
                direction = CollisionDetection.GetDirection(linkRectangle, doorRectangle);

                if (direction == "right-left")
                {
                    if (door is LeftDoor || door is LeftCave)
                    {
                        KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key - 1, manager.roomLocation.Value);
                        position = new Vector2(404, 151);
                        manager.TransitionState = true;
                        FreezeMovement.freezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        if (manager.TransitionStateFinished)
                        {
                            manager.ChangeRoom(manager.roomLocation, roomLocation, position);
                            FreezeMovement.unFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        }
                        
                    }
                    else if (door is LeftKey && game1.link.inventory.NumKeys() > 0)
                    {
                            Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                            roomdata.doorList.Insert(1, new LeftDoor(game1));
                            roomdata.doorList.RemoveAt(2);
                            roomDoors.Insert(1, new LeftDoor(game1));
                            roomDoors.RemoveAt(2);
                            game1.link.inventory.UseKey();
                            game1.link.position.X += 16;
                            roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key + 1, manager.roomLocation.Value)];
                            roomdata.doorList.Insert(2, new RightDoor(game1));
                            roomdata.doorList.RemoveAt(3);
                    }

                }
                else if (direction == "left-right")
                {
                    if (door is RightDoor || door is RightCave)
                    {
                        KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key + 1, manager.roomLocation.Value);
                        position = new Vector2(64, 151);
                        manager.TransitionState = true;
                        FreezeMovement.freezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        if (manager.TransitionStateFinished)
                        {
                            manager.ChangeRoom(manager.roomLocation, roomLocation, position);
                            FreezeMovement.unFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        }
                    }
                    else if (door is RightKey && game1.link.inventory.NumKeys() > 0)
                    {
                            Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                            roomdata.doorList.Insert(2, new RightDoor(game1));
                            roomdata.doorList.RemoveAt(3);
                            roomDoors.Insert(2, new RightDoor(game1));
                            roomDoors.RemoveAt(3);
                            game1.link.inventory.UseKey();
                            game1.link.position.X -= 16;
                            roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key + 1, manager.roomLocation.Value)];
                            roomdata.doorList.Insert(1, new LeftDoor(game1));
                            roomdata.doorList.RemoveAt(2);
                    }

                }
                else if (direction == "top-bottom")
                {
                    if (door is TopDoor || door is TopCave)
                    {
                        KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value - 1);
                        position = new Vector2(235, 246);
                        manager.TransitionState = true;
                        FreezeMovement.freezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        if (manager.TransitionStateFinished)
                        {
                            manager.ChangeRoom(manager.roomLocation, roomLocation, position);
                            FreezeMovement.unFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        }

                    }
                    else if (door is TopKey && game1.link.inventory.NumKeys() > 0)
                    {
                            Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                            roomdata.doorList.Insert(0, new TopDoor(game1));
                            roomdata.doorList.RemoveAt(1);
                            roomDoors.Insert(0, new TopDoor(game1));
                            roomDoors.RemoveAt(1);
                            game1.link.inventory.UseKey();
                            game1.link.position.Y += 16;
                            roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value - 1)];
                            roomdata.doorList.Insert(3, new BottomDoor(game1));
                            roomdata.doorList.RemoveAt(4);
                        
                    }
                }
                else if (direction == "bottom-top")
                {
                    if (door is BottomDoor || door is BottomCave)
                    {
                        KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value + 1);
                        position = new Vector2(235, 64);
                        manager.TransitionState = true;
                        FreezeMovement.freezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        if (manager.TransitionStateFinished)
                        {
                            manager.ChangeRoom(manager.roomLocation, roomLocation, position);
                            FreezeMovement.unFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                        }

                    }
                    else if (door is BottomKey && game1.link.inventory.NumKeys() > 0)
                    {
                            Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                            roomdata.doorList.Insert(3, new BottomDoor(game1));
                            roomdata.doorList.RemoveAt(4);
                            roomDoors.Insert(3, new BottomDoor(game1));
                            roomDoors.RemoveAt(4);
                            game1.link.inventory.UseKey();
                            game1.link.position.Y -= 16;
                            roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value + 1)];
                            roomdata.doorList.Insert(0, new TopDoor(game1));
                            roomdata.doorList.RemoveAt(1);
                    }
                }
            }

            return roomDoors;
        }
    }
}
