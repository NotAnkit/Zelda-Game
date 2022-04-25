using System.Collections.Generic;

namespace Zelda_Game
{
    public static class DoorKeyResponse
    {
        public static void KeyDoorResponse(IDoor door, RoomManager manager, Game1 game1, List<IDoor> roomDoors)
        {
            if(door is LeftKey)
            {
                Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                roomdata.doorList.Insert(1, new LeftDoor(game1));
                roomdata.doorList.RemoveAt(2);
                roomDoors.Insert(1, new LeftDoor(game1));
                roomDoors.RemoveAt(2);
                roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key - 1, manager.roomLocation.Value)];
                roomdata.doorList.Insert(2, new RightDoor(game1));
                roomdata.doorList.RemoveAt(3);
            }
            else if (door is RightKey)
            {
                Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                roomdata.doorList.Insert(2, new RightDoor(game1));
                roomdata.doorList.RemoveAt(3);
                roomDoors.Insert(2, new RightDoor(game1));
                roomDoors.RemoveAt(3);
                roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key + 1, manager.roomLocation.Value)];
                roomdata.doorList.Insert(1, new LeftDoor(game1));
                roomdata.doorList.RemoveAt(2);
            }
            else if (door is TopKey)
            {
                Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                roomdata.doorList.Insert(0, new TopDoor(game1));
                roomdata.doorList.RemoveAt(1);
                roomDoors.Insert(0, new TopDoor(game1));
                roomDoors.RemoveAt(1);
                roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value - 1)];
                roomdata.doorList.Insert(3, new BottomDoor(game1));
                roomdata.doorList.RemoveAt(4);
            }
            else if (door is BottomKey)
            {
                Room roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value)];
                roomdata.doorList.Insert(3, new BottomDoor(game1));
                roomdata.doorList.RemoveAt(4);
                roomDoors.Insert(3, new BottomDoor(game1));
                roomDoors.RemoveAt(4);
                roomdata = manager.roomList[new KeyValuePair<int, int>(manager.roomLocation.Key, manager.roomLocation.Value + 1)];
                roomdata.doorList.Insert(0, new TopDoor(game1));
                roomdata.doorList.RemoveAt(1);
            }
        }
    }
}
