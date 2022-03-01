using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BombRightAnimation : ISprite
    {

        public Texture2D Texture;

        public BombRightAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        private int currentFrame = 0;
        private int totalFrames = 60;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 15)
            {
                sourceRectangle = new Rectangle(129, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 40, (int)location.Y, 16, 32);
            }
            else if (currentFrame <= 30)
            {
                sourceRectangle = new Rectangle(138, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 32, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 45)
            {
                sourceRectangle = new Rectangle(155, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 32, (int)location.Y, 32, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(172, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X + 32, (int)location.Y, 32, 32);
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
