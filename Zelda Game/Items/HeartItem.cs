using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class HeartItem : IItem
    {
        public Texture2D Texture;
        private int currentFrame;
        private Vector2 position;
        private int totalFrames;

        public HeartItem(Texture2D texture)
        {
            Texture = texture;
            currentFrame = 0;
            totalFrames = 30;
        }

        public Rectangle ItemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 14, 16);
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
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 14, 16);
            position = location;

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(0, 8, 7, 8);

            else
                sourceRectangle = new Rectangle(0, 0, 7, 8);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
