using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class MovingAnimated : ISprite
    {
        int currentFrame = 0;
        int totalFrames = 4;
        Vector2 _location;

        public MovingAnimated()
        {

        }
        public void draw(SpriteBatch spriteBatch, Vector2 location, SpriteFont font)
        {
            throw new NotImplementedException();
        }

        public Vector2 draw(SpriteBatch spriteBatch, Vector2 location, Texture2D texture)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;


            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(0, 59, 42, 43);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 42, 43);

            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(56, 59, 42, 43);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 42, 43);
            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(113, 59, 42, 43);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 42, 43);
            }
            else
            {
                sourceRectangle = new Rectangle(164, 59, 42, 43);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 42, 43);

            }
            location.X -= 1;
            if (location.X <= 0)
            {
                location.X = 800;
            }
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            return _location = location;
        }

        public void update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
}
