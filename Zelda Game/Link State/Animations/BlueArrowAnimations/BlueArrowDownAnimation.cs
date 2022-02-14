using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Zelda_Game
{
    class BlueArrowDownAnimation : ISprite
    {

        public Texture2D Texture;

        public BlueArrowDownAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        int currentFrame = 0;
        int totalFrames = 60;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 12)
            {
                sourceRectangle = new Rectangle(27, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y + 32, 16, 32);
            }
            else if (currentFrame <= 24)
            {
                sourceRectangle = new Rectangle(27, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y + 64, 16, 32);
            }
            else if (currentFrame <= 36)
            {
                sourceRectangle = new Rectangle(27, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y + 96, 16, 32);
            }
            else if (currentFrame <= 48)
            {
                sourceRectangle = new Rectangle(27, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y + 128, 16, 32);
            }
            else
            {
                
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y + 160, 16, 32);
            }

            SpriteEffects s = SpriteEffects.FlipVertically;
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, Vector2.Zero, s, 0);
            return location;
        }

        public void draw(SpriteBatch spriteBatch, Vector2 location, SpriteFont font)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
}