﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Stalfos : IEnemy
    {
        private readonly Texture2D Texture;
        private int currentFrame;
        private readonly int totalFrames;
        private float spriteSpeed;
        private readonly int windowHeight;
        private readonly int windowWidth;
        private Vector2 position;
        private string direction;
        private int health;
        private Color spriteColor;

        public Rectangle EnemyRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public Rectangle ProjectileRectangle(int num)
        {
            return new Rectangle(0, 0, 0, 0);
        }

        public Stalfos(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game.WindowSizeHeight - 195;
            windowWidth = game.WindowSizeWidth - 97;
            position = location;
            direction = "right";
            health = 5;
            spriteColor = Color.White;
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
                if (position.X > windowWidth)
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
            Rectangle sourceRectangle = new Rectangle(1, 59, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            SpriteEffects s;
            if (currentFrame <= totalFrames / 2)
                s = SpriteEffects.None;
            else
                s = SpriteEffects.FlipHorizontally;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, spriteColor, 0, Vector2.Zero, s, 0);
            spriteColor = Color.White;
        }

        public void SetSpeed(float speed)
        {
            spriteSpeed = speed;
        }

        public void DecreaseHealth()
        {
            spriteColor = Color.Red;
            health--;
        }

        public int Health()
        {
            return health;
        }

        public string GetDirection()
        {
            return direction;
        }

        public void DropItem(Vector2 location)
        {
            throw new NotImplementedException();
        }
    }
}
