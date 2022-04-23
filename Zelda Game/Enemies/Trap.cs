using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Trap : IEnemyProjectile
    {
        private readonly Texture2D Texture;
        private int currentFrame;
        private readonly int totalFrames;
        private readonly float spriteSpeed;
        private readonly int windowHeight;
        private readonly int windowWidth;
        private Vector2 position;
        private Vector2 startPosition;
        private bool flip = false;

        public Rectangle EnemyRectangle(int number)
        {
            if (number == 1)
                return new Rectangle((int)position.X, (int)position.Y, 32, 32);
            else
                return new Rectangle(0, 0, 0, 0);
        }

        public Trap(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 3f;
            windowHeight = game.WindowSizeHeight;
            windowWidth = game.WindowSizeWidth;
            position = location;
            startPosition = location;
        }

        public void Update()
        {
            //if (finished == false) {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }

            if (position.X - startPosition.X <= 160 && !flip)
            {
                position.X += spriteSpeed;
            }
            else if(position.X >= startPosition.X)
            {
                flip = true;
                position.X -= spriteSpeed;
            } else
            {
                position.X = 0;
            }
        }

        public bool Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16, 32);
            bool finished = false;
            if (startPosition.X == position.X && flip)
            {
                finished = true;
            }
            if (currentFrame <= totalFrames / 3)
                sourceRectangle = new Rectangle(290, 11, 8, 16);
            else if (currentFrame > totalFrames / 3 && 2 * currentFrame <= totalFrames / 3)
                sourceRectangle = new Rectangle(299, 11, 8, 16);
            else
                sourceRectangle = new Rectangle(308, 11, 8, 16);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;
        }

    }
}
