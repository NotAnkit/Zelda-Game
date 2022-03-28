using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            controllerList = new List<IController>();
            _graphics.PreferredBackBufferWidth = 503;
            _graphics.PreferredBackBufferHeight = 345;
            _graphics.PreferredBackBufferHeight = 345 + 100;
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
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            link.Update();
            roomData.Update();
            collision.Collide(roomData);
            inventoryDisplay.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            GraphicsDevice.Clear(Color.Black);
            border.Draw(_spriteBatch, new Vector2(0, 0));
            roomData.Draw(_spriteBatch);
            link.Draw(_spriteBatch);
            inventoryDisplay.Draw(_spriteBatch);
            base.Draw(gameTime);
            _spriteBatch.End();
        }
    }
}
