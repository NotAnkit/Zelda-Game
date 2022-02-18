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
        public IEnvironment enviornment;
        public IItem item;
        public Vector2 spritePosition;
        public List<IEnvironment> blockList;
        public List<IItem> itemList;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            controllerList = new List<IController>();
            blockList = new List<IEnvironment>();
            itemList = new List<IItem>(); 

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

            itemList.Add(new CompassItem(this));
            itemList.Add(new MapItem(this));
            itemList.Add(new KeyItem(this));
            itemList.Add(new HeartContainerItem(this));
            itemList.Add(new TriforcePieceItem(this));
            itemList.Add(new BowItem(this));
            itemList.Add(new HeartItem(this));
            itemList.Add(new RupeeItem(this));
            itemList.Add(new ArrowItem(this));
            itemList.Add(new BombItem(this));
            itemList.Add(new FairyItem(this));
            itemList.Add(new ClockItem(this));

            controllerList.Add(new KeyBoardController(this, blockList, itemList));
            controllerList.Add(new EnemyController(this));
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 400;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            enviornment = blockList[0];
            item = itemList[0]; //might change -Moh
            link = new Link(spritePosition);
            enemy = new Bat(this);
            spritePosition = new Vector2(350, 250);
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            link.Update();
            enviornment.Update();
            enemy.Update();
            item.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            GraphicsDevice.Clear(Color.CornflowerBlue);

            link.draw(_spriteBatch);
            enviornment.Draw(_spriteBatch);
            enemy.Draw(_spriteBatch);
            item.Draw(_spriteBatch);

            base.Draw(gameTime);
            _spriteBatch.End();
        }
    }
}
