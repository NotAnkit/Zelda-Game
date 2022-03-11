using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Goriya : IEnemy
    {
        public Game1 Game;
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;
        public Trap trap;
        bool trapFinished = false;

        public Rectangle enemyRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public Goriya(Game1 game, Vector2 location)
        {
            Game = game;
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game._graphics.PreferredBackBufferHeight - 95;
            windowWidth = game._graphics.PreferredBackBufferWidth - 97;
            position = location;
            trap = new Trap(game, location);
            direction = "right";
        }

        private int movementCounter = 0;
        private int num = 0;
        private string direction;
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
                    position.X -= spriteSpeed;
                direction = "right";
                if (movementCounter == 0)
                {
                    trap = new Trap(Game, position);
                    trapFinished = false;
                }
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

            trap.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            SpriteEffects s;
            if (direction == "right")
            {
                s = SpriteEffects.None;
                if (currentFrame <= totalFrames / 2)
                    sourceRectangle = new Rectangle(256, 11, 16, 16);
                else
                    sourceRectangle = new Rectangle(273, 11, 16, 16);
            } else if(direction == "up")
            {
                sourceRectangle = new Rectangle(222, 11, 16, 16);
                if (currentFrame <= totalFrames / 2)
                    s = SpriteEffects.None;
                else
                    s = SpriteEffects.FlipHorizontally;
            } else if(direction == "left")
            {
                s = SpriteEffects.FlipHorizontally;
                if (currentFrame <= totalFrames / 2)
                    sourceRectangle = new Rectangle(256, 11, 16, 16);
                else
                    sourceRectangle = new Rectangle(273, 11, 16, 16);
            } else
            {
                sourceRectangle = new Rectangle(239, 11, 16, 16);
                if (currentFrame <= totalFrames / 2)
                    s = SpriteEffects.None;
                else
                    s = SpriteEffects.FlipHorizontally;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, Vector2.Zero, s, 0);
            if(!trapFinished)
                trapFinished = trap.Draw(spriteBatch);
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

