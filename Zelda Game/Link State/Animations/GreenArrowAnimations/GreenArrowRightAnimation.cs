using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class GreenArrowRightAnimation : ISprite
    {
        
        public Texture2D Texture;

        public GreenArrowRightAnimation(Texture2D texture)
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
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 32, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 24)
            {
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 64, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 36)
            {
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 96, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 48)
            {
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 128, (int)location.Y, 32, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 160, (int)location.Y, 16, 32);
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
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
