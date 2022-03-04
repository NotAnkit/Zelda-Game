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
        public ISprite sprite;
        public Link link;
        public IEnemy enemy;
        public IEnvironment environment;
        public IItem item;
        public Vector2 spritePosition;
        private IEnvironment border;
        public Level room1;
        public Room room1Blocks;
        private Collision collision;

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
            //controllerList.Add(new EnemyController(this));
            //controllerList.Add(new BlockController(this)); 
            //controllerList.Add(new ItemController(this));
            controllerList.Add(new RoomController(this));
            _graphics.PreferredBackBufferWidth = 503;
            _graphics.PreferredBackBufferHeight = 345;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            //environment = new SquareBlock(this);
            border = new BorderBlock(this);
            collision = new Collision(this);
            //item = new CompassItem(this);
            link = new Link(new Vector2(59, 150));
            //enemy = new Bat(this, new Vector2(250, 250));
            room1 = Content.Load<Level>("Room1");
            room1Blocks = new Room(room1, this);
            spritePosition = new Vector2(350, 250);
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            link.Update();
            //environment.Update();
            //enemy.Update();
            //item.Update();
            room1Blocks.Update();
            collision.Collide(room1Blocks);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            GraphicsDevice.Clear(Color.CornflowerBlue);
            border.Draw(_spriteBatch, new Vector2(0, 0));
            room1Blocks.Draw(_spriteBatch);
            link.Draw(_spriteBatch);
            //environment.Draw(_spriteBatch, new Vector2(100,100));
            //enemy.Draw(_spriteBatch, new Vector2(250, 250));
            //item.Draw(_spriteBatch);

            base.Draw(gameTime);
            _spriteBatch.End();
        }
    }
}
