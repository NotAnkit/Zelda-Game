/*using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class RoomController : IController
    {
        private MouseState currentState;
        private MouseState previousState;
        public Game1 Game;

        public RoomController(Game1 game)
        {
            Game = game;

            Game.roomList = new Dictionary<KeyValuePair<int, int>, Room>();
            Game.roomList.Add(new KeyValuePair<int, int>(0, 2), new Room(Game.Content.Load<Level>("File"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(2, 0), new Room(Game.Content.Load<Level>("Room16"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(1, 0), new Room(Game.Content.Load<Level>("Room15"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(5, 1), new Room(Game.Content.Load<Level>("Room14"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(4, 1), new Room(Game.Content.Load<Level>("Room13"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(2, 1), new Room(Game.Content.Load<Level>("Room12"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(3, 5), new Room(Game.Content.Load<Level>("Room11"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(2, 5), new Room(Game.Content.Load<Level>("Room10"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(1, 5), new Room(Game.Content.Load<Level>("Room9"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(2, 4), new Room(Game.Content.Load<Level>("Room8"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(3, 3), new Room(Game.Content.Load<Level>("Room7"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(2, 3), new Room(Game.Content.Load<Level>("Room6"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(1, 3), new Room(Game.Content.Load<Level>("Room5"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(4, 2), new Room(Game.Content.Load<Level>("Room4"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(3, 2), new Room(Game.Content.Load<Level>("Room3"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(2, 2), new Room(Game.Content.Load<Level>("Room2"), Game));
            Game.roomList.Add(new KeyValuePair<int, int>(1, 2), new Room(Game.Content.Load<Level>("Room1"), Game));

        }

        public void Update()
        {
            previousState = currentState;
            currentState = Mouse.GetState();
            if (currentState.LeftButton == ButtonState.Pressed && previousState.LeftButton != ButtonState.Pressed)
            {
                Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key + 1, Game.roomLocation.Value);
                while (!Game.roomList.ContainsKey(Game.roomLocation))
                    Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key+1, Game.roomLocation.Value);
                    if (Game.roomLocation.Key > 5)
                        Game.roomLocation = new KeyValuePair<int, int>(0, Game.roomLocation.Value);
                Game.roomData = Game.roomList[Game.roomLocation];
            }
            if (currentState.RightButton == ButtonState.Pressed && previousState.RightButton != ButtonState.Pressed)
            {
                Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key, Game.roomLocation.Value+1);
                while (!Game.roomList.ContainsKey(Game.roomLocation))
                    Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key, Game.roomLocation.Value+1);
                    if (Game.roomLocation.Value > 5)
                        Game.roomLocation = new KeyValuePair<int, int>(Game.roomLocation.Key, 0);
                Game.roomData = Game.roomList[Game.roomLocation];
            }

        }
    }
}
*/