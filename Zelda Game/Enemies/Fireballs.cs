using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Fireballs
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position1;
        private Vector2 position2;
        private Vector2 position3;

        public Rectangle enemyRectangle
        {
            get { return new Rectangle((int)position1.X, (int)position1.Y, 32, 32); }
        }

        public Fireballs(Game1 game, Vector2 startPosition)
        {
            Texture = game.Content.Load<Texture2D>("EnemySheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 3f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position1 = startPosition;
            position2 = startPosition;
            position3 = startPosition;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            if (position1.X <= windowWidth)
            {
                position1.X -= spriteSpeed;
                position1.Y -= spriteSpeed;
                position2.X -= spriteSpeed;
                position3.X -= spriteSpeed;
                position3.Y += spriteSpeed;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle1 = new Rectangle((int)position1.X, (int)position1.Y, 16, 32);
            Rectangle destinationRectangle2 = new Rectangle((int)position2.X, (int)position2.Y, 16, 32);
            Rectangle destinationRectangle3 = new Rectangle((int)position3.X, (int)position3.Y, 16, 32);

            if (currentFrame <= totalFrames / 4)
                sourceRectangle = new Rectangle(101, 11, 8, 16);
            else if (currentFrame > totalFrames / 4 && currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(110, 11, 8, 16);
            else if (currentFrame > totalFrames / 2 && currentFrame <= 3 * totalFrames / 4)
                sourceRectangle = new Rectangle(119, 11, 8, 16);
            else
                sourceRectangle = new Rectangle(128, 11, 8, 16);

            spriteBatch.Draw(Texture, destinationRectangle1, sourceRectangle, Color.White);
            spriteBatch.Draw(Texture, destinationRectangle2, sourceRectangle, Color.White);
            spriteBatch.Draw(Texture, destinationRectangle3, sourceRectangle, Color.White);
        }
    }
}
