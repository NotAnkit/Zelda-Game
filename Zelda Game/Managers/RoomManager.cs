using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class RoomManager
    {
        private readonly Game1 game1;
        public KeyValuePair<int, int> roomLocation;
        private readonly Collisions collision;
        public Room roomData;
        public Dictionary<KeyValuePair<int, int>, Room> roomList;
        private IEnvironment border;
        private Level room;
        private readonly ScreenFade fader;
        private bool tansitionState;
        private bool tansitionStateFinished;
        public bool random;

        public bool TransitionState
        {
            get => tansitionState;
            set => tansitionState = value;
        }

        public bool TransitionStateFinished => tansitionStateFinished;

        public RoomManager(Game1 game1)
        {
            this.game1 = game1;
            collision = new Collisions(this, game1.link, game1);
            roomLocation = new KeyValuePair<int, int>(2, 5);
            border = new BorderBlock(game1);
            fader = new ScreenFade(game1);
            tansitionState = false;
            tansitionStateFinished = false;
            random = false;

        }

        public void LoadRooms(Game1 Game)
        {
            roomList = new Dictionary<KeyValuePair<int, int>, Room>();
            roomList.Add(new KeyValuePair<int, int>(6, 1), new Room(Game.Content.Load<Level>("FakeRoom"), Game, false));
            roomList.Add(new KeyValuePair<int, int>(0, 2), new Room(Game.Content.Load<Level>("File"), Game, false));
            roomList.Add(new KeyValuePair<int, int>(2, 0), new Room(Game.Content.Load<Level>("Room16"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(1, 0), new Room(Game.Content.Load<Level>("Room15"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(5, 1), new Room(Game.Content.Load<Level>("Room14"), Game, false));
            roomList.Add(new KeyValuePair<int, int>(4, 1), new Room(Game.Content.Load<Level>("Room13"), Game, false));
            roomList.Add(new KeyValuePair<int, int>(2, 1), new Room(Game.Content.Load<Level>("Room12"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(3, 5), new Room(Game.Content.Load<Level>("Room11"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(2, 5), new Room(Game.Content.Load<Level>("Room10"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(1, 5), new Room(Game.Content.Load<Level>("Room9"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(2, 4), new Room(Game.Content.Load<Level>("Room8"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(3, 3), new Room(Game.Content.Load<Level>("Room7"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(2, 3), new Room(Game.Content.Load<Level>("Room6"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(1, 3), new Room(Game.Content.Load<Level>("Room5"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(4, 2), new Room(Game.Content.Load<Level>("Room4"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(3, 2), new Room(Game.Content.Load<Level>("Room3"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(2, 2), new Room(Game.Content.Load<Level>("Room2"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(1, 2), new Room(Game.Content.Load<Level>("Room1"), Game, random));
            roomList.Add(new KeyValuePair<int, int>(1, 1), new Room(Game.Content.Load<Level>("basement"), Game, false));

            room = game1.Content.Load<Level>("Room16");
            roomData = new Room(room, game1, random);
        }

        public void ChangeRoom(KeyValuePair<int, int> roomLocation, Vector2 position)
        {
            this.roomLocation = roomLocation;
            game1.link.position = position;
            roomData = roomList[this.roomLocation];
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (roomLocation.Key == 1 && roomLocation.Value == 1)
            {
                roomData.Draw(spriteBatch);
                border = new BasementBlock(game1);
                border.Draw(spriteBatch, new Vector2(0, 0));
                roomData.DrawItems(spriteBatch);

            }
            else
            {   
                border = new BorderBlock(game1);
                border.Draw(spriteBatch, new Vector2(0, 0));
                roomData.Draw(spriteBatch);
            }
        }

        public void Update()
        {
            roomData.Update();
            collision.Collide(roomData);
        }

        public void TransitionDraw(SpriteBatch spriteBatch)
        {
            tansitionState = fader.Draw(spriteBatch);
        }

        public void TransitionUpdate()
        {
            tansitionStateFinished = fader.Update();
        }
    }
}
