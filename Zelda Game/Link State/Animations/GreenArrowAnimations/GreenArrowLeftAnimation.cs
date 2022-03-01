using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class GreenArrowLeftAnimation : ISprite
    {

        public Texture2D Texture;

        public GreenArrowLeftAnimation(Texture2D texture)
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
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X - 32, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 24)
            {
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X - 64, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 36)
            {
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X - 96, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 48)
            {
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X - 128, (int)location.Y, 32, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X - 160, (int)location.Y, 16, 32);
            }

            SpriteEffects s = SpriteEffects.FlipHorizontally;
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, Vector2.Zero, s, 0);
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