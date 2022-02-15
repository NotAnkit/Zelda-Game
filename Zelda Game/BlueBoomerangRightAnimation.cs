using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class BlueBoomerangRightAnimation : ISprite
    {

        public Texture2D Texture;

        public BlueBoomerangRightAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        int currentFrame = 0;
        int totalFrames = 120;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 10)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 32, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 20)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 96, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 30)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 160, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 40)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 224, (int)location.Y, 16, 32);
            }
            else if(currentFrame <= 50)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 288, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 60)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 352, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 70)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 352, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 80)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 288, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 90)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 224, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 100)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 160, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 110)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 96, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 32, (int)location.Y, 16, 32);
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