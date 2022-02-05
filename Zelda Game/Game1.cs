using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Game1 : Game
    {
        public SpriteFont font;
        public Texture2D spriteSheet;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<IController> controllerList;
        public ISprite sprite;
        public Vector2 spritePosition;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            controllerList = new List<IController>();
            controllerList.Add(new KeyBoardController(this));
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 400;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteSheet = Content.Load<Texture2D>("Sprite Sheet");
            sprite = new NonMovingNonAnimated();
            spritePosition = new Vector2(350, 250);
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }

            sprite.update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            spritePosition = sprite.draw(_spriteBatch, spritePosition, spriteSheet);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
