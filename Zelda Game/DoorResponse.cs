
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class DoorResponse
    {
        public static void DoorCaveResponse(IDoor door, Game1 game1, RoomManager manager, Room room)
        {
            Vector2 position;
            if (door is LeftDoor || door is LeftCave)
            {
                KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key - 1, manager.roomLocation.Value);
                position = new Vector2(404, 151);
                manager.TransitionState = true;
                FreezeMovement.FreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                game1.link.ClearItems();
                if (manager.TransitionStateFinished)
                {
                    manager.ChangeRoom(roomLocation, position);
                    FreezeMovement.UnFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                }
            }
            else if (door is RightDoor || door is RightCave)
            {
                KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key + 1, manager.roomLocation.Value);
                position = new Vector2(64, 151);
                manager.TransitionState = true;
                FreezeMovement.FreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                game1.link.ClearItems();
                if (manager.TransitionStateFinished)
                {
                    manager.ChangeRoom(roomLocation, position);
                    FreezeMovement.UnFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                }
            }
            else if (door is TopDoor || door is TopCave)
            {
                KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value - 1);
                position = new Vector2(235, 246);
                manager.TransitionState = true;
                FreezeMovement.FreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                game1.link.ClearItems();
                if (manager.TransitionStateFinished)
                {
                    manager.ChangeRoom(roomLocation, position);
                    FreezeMovement.UnFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                }
            }
            else if (door is BottomDoor || door is BottomCave)
            {
                KeyValuePair<int, int> roomLocation = new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value + 1);
                position = new Vector2(235, 64);
                manager.TransitionState = true;
                FreezeMovement.FreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                game1.link.ClearItems();
                manager.ChangeRoom(roomLocation, position);
                FreezeMovement.UnFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                /*if (manager.TransitionStateFinished)
                {
                    manager.ChangeRoom(roomLocation, position);
                    FreezeMovement.UnFreezeObjects(room.enemyList, game1.link, manager.roomList[roomLocation].enemyList);
                }*/
            }
        }
    }
}
