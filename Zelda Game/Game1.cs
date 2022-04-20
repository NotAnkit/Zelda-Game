using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System.Media;

namespace Zelda_Game
{
    public class Game1 : Game
    {
        private SpriteBatch _spriteBatch;
        private List<IController> controllerList;
        private Song song;
        private readonly GraphicsDeviceManager _graphics;
        private int windowWidth;
        private int windowHeight;
        private SoundManager soundManager;

        public int WindowSizeWidth
        {
            get => windowWidth; 
            set => windowWidth = value; 
        }

        public int WindowSizeHeight
        {
            get => windowHeight; 
            set => windowHeight = value; 
        }


        public Link link;
        public InventoryDisplay inventoryDisplay;
        public ItemSelectionState itemSelectionState;
        public RoomManager manager;
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
            soundManager = new SoundManager();
            soundManager.LoadSounds(Content);
            link = new Link(new Vector2(235, 246), soundManager);
            manager = new RoomManager(this);
            manager.LoadRooms(this);
            controllerList.Add(new KeyBoardController(this));
            controllerList.Add(new GamePadController(this));
            inventoryDisplay = new InventoryDisplay(this, link.inventory);
            song = Content.Load<Song>("04 - Dungeon");
            //MediaPlayer.Play(song);
            //MediaPlayer.IsRepeating = true;
            itemSelectionState = new ItemSelectionState(this);

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
                manager.Update();
                inventoryDisplay.Update(link);
                if (manager.TransitionState)
                {
                    manager.TransitionUpdate();
                }
            }
            else
            {
                if (manager.TransitionState && !manager.TransitionStateFinished)
                {
                    manager.TransitionUpdate();
                }
                itemSelectionState.Update();
                inventoryDisplay.Update(link);

            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            GraphicsDevice.Clear(Color.Black);
            if(!pause)
            {
                manager.Draw(_spriteBatch);
                link.Draw(_spriteBatch);
                inventoryDisplay.Draw(_spriteBatch);
                if (manager.TransitionState)
                {
                    manager.TransitionDraw(_spriteBatch);
                }
            }
            else
            {
                manager.Draw(_spriteBatch);
           
                if (manager.TransitionState)
                {
                    manager.TransitionDraw(_spriteBatch);

                }
                if (manager.TransitionStateFinished)
                {
                    itemSelectionState.Draw(_spriteBatch, link);
                }
                inventoryDisplay.Draw(_spriteBatch);
            }

            base.Draw(gameTime);
            _spriteBatch.End();
        }
    }
}
