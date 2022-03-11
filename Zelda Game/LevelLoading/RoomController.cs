using Microsoft.Xna.Framework.Input;
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

            Game.roomList = new List<Room>();
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room0"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room16"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room15"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room14"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room13"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room12"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room11"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room10"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room9"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room8"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room7"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room6"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room5"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room4"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room3"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room2"), Game));
            Game.roomList.Add(new Room(Game.Content.Load<Level>("Room1"), Game));

        }

        public void Update()
        {
            previousState = currentState;
            currentState = Mouse.GetState();
            if (currentState.LeftButton == ButtonState.Pressed && previousState.LeftButton != ButtonState.Pressed)
            {
                Game.currentRoom--;
                if (Game.currentRoom < 0)
                    Game.currentRoom = Game.roomList.Count - 1;
                Game.roomData = Game.roomList[Game.currentRoom];
            }
            if (currentState.RightButton == ButtonState.Pressed && previousState.RightButton != ButtonState.Pressed)
            {
                Game.currentRoom++;
                if (Game.currentRoom >= Game.roomList.Count)
                    Game.currentRoom = 0;
                Game.roomData = Game.roomList[Game.currentRoom];
            }

        }
    }
}