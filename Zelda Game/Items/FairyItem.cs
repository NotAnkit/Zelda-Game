using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class FairyItem : IItem
    {
        private Texture2D Texture;
        private Vector2 position;
        private float spriteSpeed;
        private int currentFrame;
        private readonly int totalFrames;

        public FairyItem(Texture2D texture, Vector2 location)
        {
            Texture = texture;
            position = location;
            spriteSpeed = 1f;
            currentFrame = 0;
            totalFrames = 30;

        }

        public Rectangle ItemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 16, 32);
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
            if (position.X > 416 || position.X < 224)
                spriteSpeed = -spriteSpeed;
            

            position.X += spriteSpeed;
            
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16, 32);

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(40, 0, 8, 16);

            else
                sourceRectangle = new Rectangle(47, 0, 8, 16);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}