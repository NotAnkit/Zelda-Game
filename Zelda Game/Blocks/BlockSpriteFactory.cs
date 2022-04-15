using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class BlockSpriteFactory
    {
        private Texture2D blockSpritesheet;
        private Texture2D oldManSheet;
        private SpriteFont secretMessage;

        private static readonly BlockSpriteFactory instance = new BlockSpriteFactory();

        public static BlockSpriteFactory Instance => instance;

        private BlockSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            blockSpritesheet = content.Load<Texture2D>("RoomSheet");
            oldManSheet = content.Load<Texture2D>("Sprite Sheet");
            secretMessage = content.Load<SpriteFont>("Display");
        }

        public IEnvironment BlackBlock() => new BlackBlock(blockSpritesheet);

        public IEnvironment BigBlackBlock() => new BigBlackBlock(blockSpritesheet);

        public IEnvironment PushableBlock(Vector2 position) => new PushableBlock(blockSpritesheet, position);

        public IEnvironment BlueSand() => new BlueSand(blockSpritesheet);

        public IEnvironment BrickBlock() => new BrickBlock(blockSpritesheet);

        public IEnvironment NavyBlueBlock() => new NavyBlueBlock(blockSpritesheet);

        public IEnvironment SquareBlock() => new SquareBlock(blockSpritesheet);

        public IEnvironment Stairs() => new Stairs(blockSpritesheet);

        public IEnvironment Statue1() => new Statue1(blockSpritesheet);

        public IEnvironment Statue2() => new Statue2(blockSpritesheet);

        public IEnvironment LadderBlock() => new LadderBlock(blockSpritesheet);

        public IEnvironment OldMan() => new OldMan(oldManSheet, secretMessage);
    }
}

