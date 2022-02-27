using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        private List<IController> controllerList;
        public IEnvironment border;
        public ISprite sprite;
        public Link link;
        public IEnemy enemy;
        public IEnvironment environment;
        public IItem item;
        public Vector2 spritePosition;

        public Level room1;
        public Room room1Blocks;
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
            controllerList.Add(new EnemyController(this));
            controllerList.Add(new BlockController(this)); 
            controllerList.Add(new ItemController(this)); 
            _graphics.PreferredBackBufferWidth = 792;
            _graphics.PreferredBackBufferHeight = 495;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            environment = new SquareBlock(this);
            border = new BorderBlock(this);
            item = new CompassItem(this);
            link = new Link(spritePosition);
            enemy = new Bat(this);
            spritePosition = new Vector2(350, 250);
            room1 = Content.Load<Level>("Room1");
            room1Blocks = new Room(room1, this);
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            link.Update();
            environment.Update();
            border.Update();
            enemy.Update();
            item.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
           
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            border.Draw(_spriteBatch, new Vector2(100, 100));
            link.Draw(_spriteBatch);
            environment.Draw(_spriteBatch, new Vector2(100,100));
            enemy.Draw(_spriteBatch);
            item.Draw(_spriteBatch);
            room1Blocks.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
            
        }
    }
}
