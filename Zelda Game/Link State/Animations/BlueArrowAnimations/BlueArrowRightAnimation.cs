using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BlueArrowRightAnimation : ISprite
    {

        public Texture2D Texture;

        public BlueArrowRightAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        private int currentFrame = 0;
        private int totalFrames = 60;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 12)
            {
                sourceRectangle = new Rectangle(36, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 32, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 24)
            {
                sourceRectangle = new Rectangle(36, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 96, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 36)
            {
                sourceRectangle = new Rectangle(36, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 160, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 48)
            {
                sourceRectangle = new Rectangle(36, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 224, (int)location.Y, 32, 32);
            }
            else {

                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 288, (int)location.Y, 16, 32);
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
