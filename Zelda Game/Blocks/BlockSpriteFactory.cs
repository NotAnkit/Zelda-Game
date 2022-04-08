using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Zelda_Game
{
    public class BlockSpriteFactory
    {
        private Texture2D blockSpritesheet;

        private static BlockSpriteFactory instance = new BlockSpriteFactory();

        public static BlockSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private BlockSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            blockSpritesheet = content.Load<Texture2D>("RoomSheet");
        }

        public IEnvironment BlackBlock() => new BlackBlock(blockSpritesheet);

        public IEnvironment BigBlackBlock() => new BigBlackBlock(blockSpritesheet);

        public IEnvironment PushableBlock() => new PushableBlock(blockSpritesheet);

        public IEnvironment BlueSand() => new BlueSand(blockSpritesheet);

        public IEnvironment BrickBlock() => new BrickBlock(blockSpritesheet);

        public IEnvironment NavyBlueBlock() => new NavyBlueBlock(blockSpritesheet);

        public IEnvironment SquareBlock() => new SquareBlock(blockSpritesheet);

        public IEnvironment Stairs() => new Stairs(blockSpritesheet);

        public IEnvironment Statue1() => new Statue1(blockSpritesheet);

        public IEnvironment Statue2() => new Statue2(blockSpritesheet);

        public IEnvironment LadderBlock() => new LadderBlock(blockSpritesheet);
    }
}

