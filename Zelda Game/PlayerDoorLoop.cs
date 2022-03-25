﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{ 
    public static class PlayerDoorLoop
    {
        public static List<IDoor> PlayerLoop(List<IDoor> doorList, Game1 game1)
        {
            List<IDoor> roomDoors = doorList;
            string direction = "none";
            string previousDirection;

            foreach (IDoor door in doorList.ToArray())
            {
                Rectangle linkRectangle = game1.link.LinkRectangle;
                Rectangle doorRectangle = door.DoorRectangle();
                previousDirection = direction;
                direction = CollisionDetection.GetDirection(linkRectangle, doorRectangle);
                if (direction == "right-left")
                {
                    if (door is LeftDoor)
                    {
                        game1.roomLocation = new KeyValuePair<int, int>(game1.roomLocation.Key - 1, game1.roomLocation.Value);
                        game1.link.position = new Vector2(404, 151);
                        game1.roomData = game1.roomList[game1.roomLocation];
                    }
                    else if (door is LeftKey)
                    {
                        if (game1.link.inventory.NumKeys() > 0)
                        {
                            Room roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value)];
                            roomdata.doorList.Insert(1, new LeftDoor(game1));
                            roomdata.doorList.RemoveAt(2);
                            roomDoors.Insert(1, new LeftDoor(game1));
                            roomDoors.RemoveAt(2);
                            game1.link.inventory.UseKey();
                            game1.link.position.X += 16;
                            roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key + 1, game1.roomLocation.Value)];
                            roomdata.doorList.Insert(2, new RightDoor(game1));
                            roomdata.doorList.RemoveAt(3);
                        }
                    }

                }
                if (direction == "left-right")
                {
                    if (door is RightDoor)
                    {
                        game1.roomLocation = new KeyValuePair<int, int>(game1.roomLocation.Key + 1, game1.roomLocation.Value);
                        game1.link.position = new Vector2(64, 151);
                        game1.roomData = game1.roomList[game1.roomLocation];
                    }
                    else if (door is RightKey)
                    {
                        if (game1.link.inventory.NumKeys() > 0)
                        {
                            Room roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value)];
                            roomdata.doorList.Insert(2, new RightDoor(game1));
                            roomdata.doorList.RemoveAt(3);
                            roomDoors.Insert(2, new RightDoor(game1));
                            roomDoors.RemoveAt(3);
                            game1.link.inventory.UseKey();
                            game1.link.position.X -= 16;
                            roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key+1, game1.roomLocation.Value)];
                            roomdata.doorList.Insert(1, new LeftDoor(game1));
                            roomdata.doorList.RemoveAt(2);

                        }
                    }

                }
                if (direction == "top-bottom")
                {
                    if (door is TopDoor)
                    {
                        game1.roomLocation = new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value - 1);
                        game1.link.position = new Vector2(235, 246);
                        game1.roomData = game1.roomList[game1.roomLocation];
                    }
                    else if (door is TopKey)
                    {
                        if (game1.link.inventory.NumKeys() > 0)
                        {
                            Room roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value)];
                            roomdata.doorList.Insert(0, new TopDoor(game1));
                            roomdata.doorList.RemoveAt(1);
                            roomDoors.Insert(0, new TopDoor(game1));
                            roomDoors.RemoveAt(1);
                            game1.link.inventory.UseKey();
                            game1.link.position.Y += 16;
                            roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value - 1)];
                            roomdata.doorList.Insert(3, new BottomDoor(game1));
                            roomdata.doorList.RemoveAt(4);
                        }
                    }

                }
                if (direction == "bottom-top")
                {
                    if (door is BottomDoor)
                    {
                        game1.roomLocation = new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value + 1);
                        game1.link.position = new Vector2(235, 64);
                        game1.roomData = game1.roomList[game1.roomLocation];
                    }
                    else if (door is BottomKey)
                    {
                        if (game1.link.inventory.NumKeys() > 0)
                        {
                            Room roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value)];
                            roomdata.doorList.Insert(0, new TopDoor(game1));
                            roomdata.doorList.RemoveAt(1);
                            roomDoors.Insert(3, new BottomDoor(game1));
                            roomDoors.RemoveAt(4);
                            game1.link.inventory.UseKey();
                            game1.link.position.Y -= 16;
                            roomdata = game1.roomList[new KeyValuePair<int, int>(game1.roomLocation.Key, game1.roomLocation.Value + 1)];
                            roomdata.doorList.Insert(0, new TopDoor(game1));
                            roomdata.doorList.RemoveAt(1);
                        }
                    }
                }
            }

            return roomDoors;
        }
    }
}
