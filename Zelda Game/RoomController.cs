﻿using Microsoft.Xna.Framework;
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
            roomList.Add(new Room(Game.Content.Load<Level>("Room16"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room15"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room14"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room13"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room12"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room11"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room10"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room9"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room8"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room7"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room6"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room5"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room4"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room3"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room2"), Game));
            roomList.Add(new Room(Game.Content.Load<Level>("Room1"), Game));

        }

        public void Update()
        {
            previousState = currentState;
            currentState = Mouse.GetState();
            if (currentState.LeftButton == ButtonState.Pressed && previousState.LeftButton != ButtonState.Pressed)
            {
                currentRoomValue--;
                if (currentRoomValue < 0)
                    currentRoomValue = roomList.Count - 1;
                Game.room1Blocks = roomList[currentRoomValue];
            }
            if (currentState.RightButton == ButtonState.Pressed && previousState.RightButton != ButtonState.Pressed)
            {
                currentRoomValue++;
                if (currentRoomValue >= roomList.Count)
                    currentRoomValue = 0;
                Game.room1Blocks = roomList[currentRoomValue];
            }

        }
    }
}