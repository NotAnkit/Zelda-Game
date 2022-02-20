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

        public Goriya(Game1 game)
        {
            Game = game;
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position = new Vector2(windowWidth / 2, windowHeight / 2);
            trap = new Trap(game, position);
        }

        int movementCounter = 0;
        int num = 0;
        String goriyaState;
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
                goriyaState = "right";
                if(movementCounter == 0)
                    trap = new Trap(Game, position);
            }
            else if (num % 4 == 1)
            {
                position.Y += spriteSpeed;
                if (position.Y > windowHeight)
                    position.Y = 0;
                goriyaState = "up";
            }
            else if (num % 4 == 2)
            {
                position.X -= spriteSpeed;
                if (position.X < 0)
                    position.X = windowWidth;
                goriyaState = "left";
            }
            else
            {
                position.Y -= spriteSpeed;
                if (position.Y < 0)
                    position.Y = windowHeight;
                goriyaState = "down";
            }

            trap.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            SpriteEffects s;
            if (goriyaState == "right")
            {
                s = SpriteEffects.None;
                if (currentFrame <= totalFrames / 2)
                    sourceRectangle = new Rectangle(256, 11, 16, 16);
                else
                    sourceRectangle = new Rectangle(273, 11, 16, 16);
            } else if(goriyaState == "up")
            {
                sourceRectangle = new Rectangle(222, 11, 16, 16);
                if (currentFrame <= totalFrames / 2)
                    s = SpriteEffects.None;
                else
                    s = SpriteEffects.FlipHorizontally;
            } else if(goriyaState == "left")
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
            trap.Draw(spriteBatch);
        }

    }
}

