using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Game1 : Game
    {
        private SpriteBatch _spriteBatch;
        private List<IController> controllerList;
        public Link link;
        private IEnvironment border;
        private Level room;
        private Collision collision;
        public int currentRoom;
        public KeyValuePair<int, int> roomLocation;
        public Room roomData;
        public GraphicsDeviceManager _graphics;
        public Dictionary<KeyValuePair<int, int>, Room> roomList;
        private InventoryDisplay inventoryDisplay;
        public Song song;
        public int windowWidth;
        public int windowHeight;

        private ItemSelectionState itemSelectionState;

        public RoomManager switcher;
        public bool tansitionState;
        public bool tansitionStateFinished;

        public bool pause;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            controllerList = new List<IController>();
            windowWidth = _graphics.PreferredBackBufferWidth = 503;
            windowHeight = _graphics.PreferredBackBufferHeight = 445;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            controllerList.Add(new RoomController(this));
            controllerList.Add(new KeyBoardController(this));
            border = new BorderBlock(this);
            collision = new Collision(this);
            roomLocation = new KeyValuePair<int, int>(2, 5);
            link = new Link(new Vector2(235, 246));
            room = Content.Load<Level>("Room10");
            roomData = new Room(room, this);

            inventoryDisplay = new InventoryDisplay(this);
            song = Content.Load<Song>("04 - Dungeon");
            //MediaPlayer.Play(song);
            //MediaPlayer.IsRepeating = true;
            itemSelectionState = new ItemSelectionState(this);

            switcher = new RoomManager(this);
            tansitionState = false;
            tansitionStateFinished = false;

            pause = false;

        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            if (!pause)
            {
                link.Update();
                roomData.Update();
                collision.Collide(roomData);
                inventoryDisplay.Update();
                if (tansitionState)
                {
                    switcher.Update();
                }
            }
            else
            {
                inventoryDisplay.Update();
                itemSelectionState.Update();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            GraphicsDevice.Clear(Color.Black);
            if(!pause)
            {
                border.Draw(_spriteBatch, new Vector2(0, 0));
                roomData.Draw(_spriteBatch);
                link.Draw(_spriteBatch);
                inventoryDisplay.Draw(_spriteBatch);
                if (tansitionState)
                {
                    switcher.Draw(_spriteBatch);
                }
            }
            else
            {
                inventoryDisplay.Draw(_spriteBatch);
                itemSelectionState.Draw(_spriteBatch);
            }

            base.Draw(gameTime);
            _spriteBatch.End();
        }
    }
}
