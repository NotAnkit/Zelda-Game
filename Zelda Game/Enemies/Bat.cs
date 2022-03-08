using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Bat : IEnemy
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;
        public string direction;

        public Bat(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game._graphics.PreferredBackBufferHeight - 230;
            windowWidth = game._graphics.PreferredBackBufferWidth  - 380;
            position = location;
            direction = "right";
        }

        public Rectangle enemyRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        private int movementCounter;
        private int num;

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            Random rnd = new Random();
            movementCounter++;
            if (movementCounter == totalFrames * 2)
            {
                num = rnd.Next();
                movementCounter = 0;
            }

            if (num % 4 == 0)
            {
                position.X += spriteSpeed;
                if (position.X > windowWidth - 16)
                    position.X -= spriteSpeed;
                direction = "right";
            }
            else if (num % 4 == 1)
            {
                position.Y += spriteSpeed;
                if (position.Y > windowHeight)
                    position.Y -= spriteSpeed;
                direction = "up";
            }
            else if (num % 4 == 2)
            {
                position.X -= spriteSpeed;
                if (position.X < 59)
                    position.X += spriteSpeed;
                direction = "left";
            }
            else
            {
                position.Y -= spriteSpeed;
                if (position.Y < 61)
                    position.Y += spriteSpeed;
                direction = "down";
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            if (currentFrame <= totalFrames/2)
                sourceRectangle = new Rectangle(183, 11, 16, 16);
            else
                sourceRectangle = new Rectangle(200, 11, 16, 16);

            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            
        }

        public float GetSpeed()
        {
            return spriteSpeed;
        }

        public void SetSpeed(float speed)
        {
            spriteSpeed = speed;
        }

        public string GetDirection()
        {
            return direction;
        }

        public void SetPosition(Vector2 newPosition)
        {
            position = newPosition;
        }
    }
}

