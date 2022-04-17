using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class LinkWoodSwordUpAnimation : ISprite
    {
        private Texture2D Texture;

        public LinkWoodSwordUpAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        private int currentFrame = 0;
        private readonly int totalFrames = 30;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 7)
            {
                sourceRectangle = new Rectangle(141, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 15)
            {
                sourceRectangle = new Rectangle(18, 97, 16, 27);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y-24, 32, 54);

            }
            else if (currentFrame <= 22)
            {
                sourceRectangle = new Rectangle(35, 97, 16, 27);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y-24, 32, 54);
            }
            else
            {
                sourceRectangle = new Rectangle(52, 97, 16, 27);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y-24, 32, 54);
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
