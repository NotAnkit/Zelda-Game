﻿using Microsoft.Xna.Framework.Graphics;
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
        private Vector2 startPosition;
        bool flip = false;

        public Rectangle enemyRectangle
        {
            get { return new Rectangle((int)position.X, (int)position.Y, 32, 32); }
        }

        public Trap(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 3f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position = location;
            startPosition = location;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }

            if (position.X - startPosition.X <= 160 && !flip)
            {
                position.X += spriteSpeed;
            }
            else
            {
                flip = true;
                position.X -= spriteSpeed;
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
