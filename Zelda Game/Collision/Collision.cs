using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;

        private List<Vector2> deleteEnemy;

        public Collision(Game1 game)
        {
            Game = game;
            deleteEnemy = new List<Vector2>();
        }

        public void Collide(Room room)
        {
            string direction = "none";
            string previousDirection;
            List<IDoor> roomDoors = room.doorList;

            PlayerEnemyLoop.EnemyLoop(room.enemyList, Game.link, room.blockList);

            PlayerBlockLoop.BlockLoop(room.blockList, Game.link);

            room.itemList = ItemResponseLoop.ItemLoop(room.itemList, Game.link);
            //Player Door Collision
            foreach (IDoor door in room.doorList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle doorRectangle = door.DoorRectangle();
                previousDirection = direction;
                direction = CollisionDetection.GetDirection(linkRectangle, doorRectangle);
                if (direction == "right-left")
                {
                    if(door is LeftDoor)
                    {
                        Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key - 1, Game.roomLocation.Value);
                        Game.link.position = new Vector2(404, 151);
                        Game.roomData = Game.roomList[Game.roomLocation];
                    }
                    else if(door is LeftSealed)
                    {
                        if(Game.link.inventory.Contains(ItemSpriteFactory.Instance.KeyItem()))
                        {
                            roomDoors.Remove(door);
                            roomDoors.Add(new LeftDoor(Game));
                        }
                    }

                }
                if (direction == "left-right")
                {
                    if(door is RightDoor)
                    {
                        Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key + 1, Game.roomLocation.Value);
                        Game.link.position = new Vector2(64, 151);
                        Game.roomData = Game.roomList[Game.roomLocation];
                    }
                    else if (door is RightSealed)
                    {
                        if (Game.link.inventory.Contains(ItemSpriteFactory.Instance.KeyItem()))
                        {
                            roomDoors.Remove(door);
                            roomDoors.Add(new RightDoor(Game));
                        }
                    }

                }
                if (direction == "top-bottom")
                {
                    if(door is TopDoor)
                    {
                        Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key, Game.roomLocation.Value - 1);
                        Game.link.position = new Vector2(235, 480);
                        Game.roomData = Game.roomList[Game.roomLocation];
                    }
                    else if (door is TopSealed)
                    {
                        if (Game.link.inventory.Contains(ItemSpriteFactory.Instance.KeyItem()))
                        {
                            roomDoors.Remove(door);
                            roomDoors.Add(new TopDoor(Game));
                        }
                    }

                }
                if (direction == "bottom-top")
                {
                    if(door is BottomDoor)
                    {
                        Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key, Game.roomLocation.Value + 1);
                        Game.link.position = new Vector2(235, 246);
                        Game.roomData = Game.roomList[Game.roomLocation];
                    }
                    else if (door is BottomSealed)
                    {
                        if (Game.link.inventory.Contains(ItemSpriteFactory.Instance.KeyItem()))
                        {
                            roomDoors.Remove(door);
                            roomDoors.Add(new BottomDoor(Game));
                        }
                    }
                }
            }

            room.doorList = roomDoors;

        }
    }
}
