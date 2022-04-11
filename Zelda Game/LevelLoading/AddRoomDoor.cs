using System.Collections.Generic;

namespace Zelda_Game
{
    public class AddDoors
    {
        private static readonly AddDoors instance = new AddDoors();

        public static AddDoors Instance => instance;

        private AddDoors()
        {

        }

        public List<IDoor> LoadDoors(List<IDoor> doorList, string doorType, Game1 game1)
        {
            if (doorType.Equals("TopWall"))
            {
                doorList.Add(new TopWall(game1));
            }
            else if (doorType.Equals("TopDoor"))
            {
                doorList.Add(new TopDoor(game1));
            }
            else if (doorType.Equals("TopKey"))
            {
                doorList.Add(new TopKey(game1));
            }
            else if (doorType.Equals("TopSealed"))
            {
                doorList.Add(new TopSealed(game1));
            }
            else if (doorType.Equals("TopCave"))
            {
                doorList.Add(new TopCave(game1));
            }

            if (doorType.Equals("LeftWall"))
            {
                doorList.Add(new LeftWall(game1));
            }
            else if (doorType.Equals("LeftDoor"))
            {
                doorList.Add(new LeftDoor(game1));
            }
            else if (doorType.Equals("LeftKey"))
            {
                doorList.Add(new LeftKey(game1));
            }
            else if (doorType.Equals("LeftSealed"))
            {
                doorList.Add(new LeftSealed(game1));
            }
            else if (doorType.Equals("LeftCave"))
            {
                doorList.Add(new LeftCave(game1));
            }

            if (doorType.Equals("RightWall"))
            {
                doorList.Add(new RightWall(game1));
            }
            else if (doorType.Equals("RightDoor"))
            {
                doorList.Add(new RightDoor(game1));
            }
            else if (doorType.Equals("RightKey"))
            {
                doorList.Add(new RightKey(game1));
            }
            else if (doorType.Equals("RightSealed"))
            {
                doorList.Add(new RightSealed(game1));
            }
            else if (doorType.Equals("RightCave"))
            {
                doorList.Add(new RightCave(game1));
            }

            if (doorType.Equals("BottomWall"))
            {
                doorList.Add(new BottomWall(game1));
            }
            else if (doorType.Equals("BottomDoor"))
            {
                doorList.Add(new BottomDoor(game1));
            }
            else if (doorType.Equals("BottomKey"))
            {
                doorList.Add(new BottomKey(game1));
            }
            else if (doorType.Equals("BottomSealed"))
            {
                doorList.Add(new BottomSealed(game1));
            }
            else if (doorType.Equals("BottomCave"))
            {
                doorList.Add(new BottomCave(game1));
            }
            return doorList;
        }
    }
}