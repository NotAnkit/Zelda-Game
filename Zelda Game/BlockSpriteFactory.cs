using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
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

        //changed to private, originally public
        private BlockSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            blockSpritesheet = content.Load<Texture2D>("RoomSheet");
        }

        public IEnviornment BlackBlock()
        {
            return new (blockSpritesheet, 984, 28);
        }

        public IEnviornment PushableBlock()
        {
            return new(blockSpritesheet, 1001, 11);
        }

        public IEnviornment BlueSand()
        {
            return new(blockSpritesheet, 1001, 28);
        }

        public IEnviornment BrickBlock()
        {
            return new(blockSpritesheet, 984, 45);
        }

        public IEnviornment NavyBlueBlock()
        {
            return new(blockSpritesheet, 1018, 28);
        }

        public IEnviornment SquareBlock()
        {
            return new(blockSpritesheet, 984, 11);
        }

        public IEnviornment Stairs()
        {
            return new(blockSpritesheet, 1035, 28);
        }

        public IEnviornment Statue1()
        {
            return new(blockSpritesheet, 1018, 11);
        }

        public IEnviornment Statue2()
        {
            return new(blockSpritesheet, 1035, 11);
        }

        public IEnviornment LadderBlock()
        {
            return new(blockSpritesheet, 1001, 45);
        }
    }
}
