﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Threading;

namespace Zelda_Game
{
    /*animate and move arbitrarily across screen*/
    public class Stalfos : IEnemy
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;

        public Stalfos(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 60;
            spriteSpeed = 5f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position = new Vector2(windowWidth / 2, windowHeight / 2);
        }

        int movementCounter = 0;
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            Random Rnd = new Random();
            if(movementCounter == 10)
            {
                Rnd = new Random();
            }
            movementCounter++;

            int num = Rnd.Next();
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
            Rectangle sourceRectangle = new Rectangle(1, 59, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            if (currentFrame <= 30)
                sourceRectangle = new Rectangle(1, 59, 16, 16); /*normal*/
            else
                sourceRectangle = new Rectangle(1, 59, 16, 16); /*flip*/

            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            
        }

    }
}
