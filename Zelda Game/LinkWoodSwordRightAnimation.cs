using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class LinkWoodSwordRightAnimated : ISprite
    {
        int currentFrame = 0;
        int totalFrames = 4;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location, Texture2D texture)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(124, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 16);
            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(18, 77, 27, 17);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 27, 17);
            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(46, 77, 23, 17);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 23, 17);
            }
            else
            {
                sourceRectangle = new Rectangle(70, 77, 19, 17);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 19, 17);
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
