using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Fireballs
    {
        public readonly Texture2D Texture;
        private int currentFrame;
        private readonly int totalFrames;
        private float spriteSpeed1X;
        private float spriteSpeed1Y;
        private float spriteSpeed2X;
        private float spriteSpeed3X;
        private float spriteSpeed3Y;
        private readonly int windowHeight;
        private readonly int windowWidth;
        private Vector2 position1;
        private Vector2 position2;
        private Vector2 position3;

        public Rectangle EnemyRectangle
        {
            get { return new Rectangle((int)position1.X, (int)position1.Y, 32, 32); }
        }

        public Fireballs(Game1 game, Vector2 startPosition)
        {
            Texture = game.Content.Load<Texture2D>("EnemySheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed1X = 3f;
            spriteSpeed1Y = 3f;
            spriteSpeed2X = 3f;
            spriteSpeed3X = 3f;
            spriteSpeed3Y = 3f;
            windowHeight = game.WindowSizeHeight;
            windowWidth = game.WindowSizeWidth;
            position1 = startPosition;
            position2 = startPosition;
            position3 = startPosition;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            position1.X -= spriteSpeed1X;
            position1.Y -= spriteSpeed1Y;

            position2.X -= spriteSpeed2X;

            position3.X -= spriteSpeed3X;
            position3.Y += spriteSpeed3Y;

            if (position1.X < 59)
            {
                spriteSpeed1X = spriteSpeed1X*-1;
            }
            else if (position1.X > windowWidth - 97)
            {
                spriteSpeed1X = -spriteSpeed1X;
            }
            if (position1.Y > windowHeight - 197)
            {
                spriteSpeed1Y = -spriteSpeed1Y;
            }
            else if (position1.Y < 61)
            {
                spriteSpeed1Y = spriteSpeed1Y * -1;
            }

            if (position2.X < 59)
            {
                spriteSpeed2X = spriteSpeed2X * -1;
            }
            else if (position2.X > windowWidth - 97)
            {
                spriteSpeed2X = -spriteSpeed2X;
            }

            if (position3.X < 59)
            {
                spriteSpeed3X = spriteSpeed3X * (-1);
            }
            else if (position3.X > windowWidth - 97)
            {
                spriteSpeed3X = -spriteSpeed3X;
            }
            if (position3.Y > windowHeight - 197)
            {
                spriteSpeed3Y = -spriteSpeed3Y;
            }
            else if (position3.Y < 61)
            {
                spriteSpeed3Y = spriteSpeed3Y * -1;
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
