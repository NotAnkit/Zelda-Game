using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerProjectileLoop
    {
        public static List<IDoor> ProjectileLoop(Link player, List<IDoor> roomDoors, KeyValuePair<int, int> roomLocation, Game1 game1)
        {
            string direction;
            List<IDoor> doorList = roomDoors;
            foreach (KeyValuePair<IProjectile, Vector2> projectile in player.items)
            {
                Rectangle projectileRectangle = projectile.Key.ProjectileRectangle();
                foreach (IDoor door in roomDoors.ToArray())
                {
                    if(door is TopWall && (roomLocation.Key == 2 || roomLocation.Key == 3) && roomLocation.Value == 3)
                    {
                        Rectangle doorRectangle = door.DoorRectangle();
                        direction = CollisionDetection.GetDirection(projectileRectangle, doorRectangle);
                        if (direction !=  "none" && projectile.Key is BombUpAnimation)
                        {
                            doorList.Insert(0, new TopCave(game1));
                            doorList.RemoveAt(1);
                            Room nextRoomdata = game1.roomList[new KeyValuePair<int, int>(roomLocation.Key, roomLocation.Value - 1)];
                            nextRoomdata.doorList.Insert(3, new BottomCave(game1));
                            nextRoomdata.doorList.RemoveAt(4);
                        }   
                    }
                    else if (door is BottomWall && (roomLocation.Key == 2 || roomLocation.Key == 3) && roomLocation.Value == 2)
                    {
                          Rectangle doorRectangle = projectile.Key.ProjectileRectangle();
                          direction = CollisionDetection.GetDirection(projectileRectangle, doorRectangle);
                          if (direction != "none" && projectile.Key is BombDownAnimation)
                          {   
                              doorList.Insert(3, new BottomCave(game1));
                              doorList.RemoveAt(4);
                              Room nextRoomdata = game1.roomList[new KeyValuePair<int, int>(roomLocation.Key, roomLocation.Value + 1)];
                              nextRoomdata.doorList.Insert(0, new TopCave(game1));
                              nextRoomdata.doorList.RemoveAt(1);
                          }
                    }

                }
            }
            return doorList;
        }
    }
}
