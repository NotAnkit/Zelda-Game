using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class LinkWoodSwordDownAnimated : ISprite
    {
        int currentFrame = 0;
        int totalFrames = 4;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location, Texture2D texture)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(107, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 16);
            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(18, 47, 16, 27);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 27);
            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(35, 47, 16, 23);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 23);
            }
            else
            {
                sourceRectangle = new Rectangle(52, 47, 16, 19);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 19);
            }

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
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