using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class RupeeItem : IItem
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private Vector2 position;

        public RupeeItem(Texture2D texture)
        {
            Texture = texture;
            
            currentFrame = 0;
            totalFrames = 30;
        }

        public Rectangle itemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 16, 32);
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
            position = location;

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(72, 16, 8, 16);
                
            else
                sourceRectangle = new Rectangle(72, 0, 8, 16);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
