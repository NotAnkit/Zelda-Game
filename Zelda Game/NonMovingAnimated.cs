using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class NonMovingAnimated : ISprite
    {
        int currentFrame = 0;
        int totalFrames = 4;
        public Vector2 draw(SpriteBatch spriteBatch, Vector2 location, Texture2D texture)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(9, 4, 35, 49);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 35, 49);
            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(66, 4, 35, 49);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 35, 49);
            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(123, 4, 35, 49);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 35, 49);
            }
            else
            {
                sourceRectangle = new Rectangle(180, 4, 35, 49);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 35, 49);
            }

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            return location;
        }

        public void draw(SpriteBatch spriteBatch, Vector2 location, SpriteFont font)
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
}
