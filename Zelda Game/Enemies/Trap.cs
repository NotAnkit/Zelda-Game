using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Trap
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;

        public Trap(Game1 game, Vector2 startPosition)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 3f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position = startPosition;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

             if (position.X <= windowWidth)
                position.X += spriteSpeed;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16, 32);

            if (currentFrame <= totalFrames / 3)
                sourceRectangle = new Rectangle(290, 11, 8, 16);
            else if (currentFrame > totalFrames / 3 && 2 * currentFrame <= totalFrames / 3)
                sourceRectangle = new Rectangle(299, 11, 8, 16);
            else
                sourceRectangle = new Rectangle(308, 11, 8, 16);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

    }
}
