using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LinkRightAnimation : ISprite
    {
       
        public Texture2D Texture;

        public LinkRightAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        private int currentFrame = 0;
        private readonly int totalFrames = 60;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 30)
            {
                sourceRectangle = new Rectangle(35, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 30, 30);
            }
            else
            {
                sourceRectangle = new Rectangle(52, 11, 16, 16);
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
