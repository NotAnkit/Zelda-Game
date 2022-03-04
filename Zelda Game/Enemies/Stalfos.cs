using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Stalfos : IEnemy
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;

        public Rectangle enemyRectangle
        {
            get { return new Rectangle((int)position.X, (int)position.Y, 32, 32); }
        }

        public Stalfos(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game._graphics.PreferredBackBufferHeight - 230;
            windowWidth = game._graphics.PreferredBackBufferWidth - 380;
            position = location;
        }

        private int movementCounter = 0;
        private int num = 0;
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            Random rnd = new Random();
            movementCounter++;
            if (movementCounter == 2 * totalFrames)
            {
                num = rnd.Next(); 
                movementCounter = 0;
            }

            if (num % 4 == 0)
            {
                position.X += spriteSpeed;
                if (position.X > windowWidth - 16)
                    position.X -= spriteSpeed;
            }
            else if (num % 4 == 1)
            {
                position.Y += spriteSpeed;
                if (position.Y > windowHeight)
                    position.Y -= spriteSpeed;
            }
            else if (num % 4 == 2)
            {
                position.X -= spriteSpeed;
                if (position.X < 59)
                    position.X += spriteSpeed;
            }
            else
            {
                position.Y -= spriteSpeed;
                if (position.Y < 61)
                    position.Y += spriteSpeed;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1, 59, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            SpriteEffects s;
            if (currentFrame <= totalFrames / 2)
                s = SpriteEffects.None;
            else
                s = SpriteEffects.FlipHorizontally;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, Vector2.Zero, s, 0);  
        }

    }
}
