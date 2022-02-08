using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Game1 : Game
    {
        public SpriteFont font;
        public Texture2D spriteSheet;
        public GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<IController> controllerList;
        public ISprite sprite;
        public Link link;
        public IEnemy enemy;
        public IEnviornment enviornment;
        public Vector2 spritePosition;
<<<<<<< Updated upstream
        private Game1 game;
        public List<IEnviornment> blockList;

=======
>>>>>>> Stashed changes

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            controllerList = new List<IController>();
            controllerList = new List<IController>();
            blockList = new List<IEnviornment>();

            blockList.Add(new SquareBlock(this));
            blockList.Add(new BlackBlock(this));
            blockList.Add(new BlueSand(this));
            blockList.Add(new BrickBlock(this));
            blockList.Add(new LadderBlock(this));
            blockList.Add(new NavyBlueBlock(this));
            blockList.Add(new PushableBlock(this));
            blockList.Add(new Stairs(this));
            blockList.Add(new Statue1(this));
            blockList.Add(new Statue2(this));

            controllerList.Add(new KeyBoardController(this, blockList));
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
            link = new Link(game);
            enviornment = blockList[0];
            spritePosition = new Vector2(350, 250);
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            link.Update();
            sprite.Update();
            enviornment.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            spritePosition = sprite.Draw(_spriteBatch, spritePosition, spriteSheet);
            _spriteBatch.End();
            enviornment.Draw(_spriteBatch);

            base.Draw(gameTime);
        }
    }
}
