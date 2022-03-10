using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LinkDownAnimation : ISprite
    {
        public Texture2D Texture;

        public LinkDownAnimation(Texture2D texture)
        {
            Texture = texture;
            
        }

        private int currentFrame = 0;
        private int totalFrames = 60;

        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 30)
            {
                sourceRectangle = new Rectangle(1, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 30, 30);
            }
            else
            {
                sourceRectangle = new Rectangle(18, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 30, 30);
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