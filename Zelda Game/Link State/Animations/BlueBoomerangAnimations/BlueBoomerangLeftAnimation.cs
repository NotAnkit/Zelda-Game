using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BlueBoomerangLeftAnimation : ISprite
    {

        public Texture2D Texture;

        public BlueBoomerangLeftAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        private int currentFrame = 0;
        private int totalFrames = 120;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 5)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 32, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 10)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 96, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 15)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 160, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 20)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 224, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 25)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 288, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 30)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 352, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 35)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 352, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 40)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 288, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 45)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 224, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 50)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 160, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 55)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 96, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 32, (int)location.Y, 16, 32);
            }


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return location;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
}
