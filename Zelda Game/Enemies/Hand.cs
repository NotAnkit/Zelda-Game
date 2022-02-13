using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Hand : IEnemy
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;

        public Hand(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position = new Vector2(windowWidth / 2, windowHeight / 2);
        }

        int movementCounter = 0;
        int num = 0;
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
                if (position.X > windowWidth)
                    position.X = 0;
            }
            else if (num % 4 == 1)
            {
                position.Y += spriteSpeed;
                if (position.Y > windowHeight)
                    position.Y = 0;
            }
            else if (num % 4 == 2)
            {
                position.X -= spriteSpeed;
                if (position.X < 0)
                    position.X = windowWidth;
            }
            else
            {
                position.Y -= spriteSpeed;
                if (position.Y < 0)
                    position.Y = windowHeight;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(393, 11, 16, 16);
            else
                sourceRectangle = new Rectangle(410, 11, 16, 16);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            
        }

    }
}


