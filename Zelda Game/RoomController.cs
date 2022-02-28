using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class RoomController : IController
    {
        private MouseState currentState;
        private MouseState previousState;
        public Game1 Game;
        public int currentRoomValue = 0;

        private List<Room> roomList;

        public RoomController(Game1 game)
        {
            Game = game;
            roomList = new List<Room>();
            roomList.Add(new Room(Game.Content.Load<Level>("Room1"), Game));
        }

        public void Update()
        {
            previousState = currentState;
            currentState = Mouse.GetState();
            if (currentState.LeftButton == ButtonState.Pressed && currentState.LeftButton != ButtonState.Pressed)
            {
                currentRoomValue--;
                if (currentRoomValue < 0)
                    currentRoomValue = roomList.Count - 1;
                Game.room1Blocks = roomList[currentRoomValue];
            }
            if (currentState.RightButton == ButtonState.Pressed && currentState.RightButton != ButtonState.Pressed)
            {
                currentRoomValue++;
                if (currentRoomValue >= roomList.Count)
                    currentRoomValue = 0;
                Game.room1Blocks = roomList[currentRoomValue];
            }

        }
    }
}