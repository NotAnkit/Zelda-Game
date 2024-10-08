﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Goriya : IEnemy
    {
        private readonly Game1 Game;
        private readonly Texture2D Texture;
        private int currentFrame;
        private readonly int totalFrames;
        private float spriteSpeed;
        private readonly int windowHeight;
        private readonly int windowWidth;
        private Vector2 position;
        private int health;
        private Trap trap;
        private bool trapFinished = false;
        private Color spriteColor;
        private int count;

        public Rectangle EnemyRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public Rectangle ProjectileRectangle(int num)
        {
            return trap.EnemyRectangle(num);
        }

        public Goriya(Game1 game, Vector2 location)
        {
            Game = game;
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game.WindowSizeHeight - 195;
            windowWidth = game.WindowSizeWidth - 97;
            position = location;
            health = 5;
            trap = new Trap(game, location);
            direction = "right";
            spriteColor = Color.White;
        }

        private int movementCounter = 0;
        private int num = 0;
        private string direction;
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            if (count < 20)
            {
                count++;
            }

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

            SpriteEffects s = SpriteEffects.None;

            if (count < 20)
            {
                sourceRectangle = new Rectangle(339, 5, 13, 17);
            }
            else if (health <= 0)
            {
                sourceRectangle = new Rectangle(355, 5, 13, 17);
            }
            else
            {

                if (direction == "right")
                {
                    s = SpriteEffects.None;
                    if (currentFrame <= totalFrames / 2)
                        sourceRectangle = new Rectangle(256, 11, 16, 16);
                    else
                        sourceRectangle = new Rectangle(273, 11, 16, 16);
                }
                else if (direction == "up")
                {
                    sourceRectangle = new Rectangle(222, 11, 16, 16);
                    if (currentFrame <= totalFrames / 2)
                        s = SpriteEffects.None;
                    else
                        s = SpriteEffects.FlipHorizontally;
                }
                else if (direction == "left")
                {
                    s = SpriteEffects.FlipHorizontally;
                    if (currentFrame <= totalFrames / 2)
                        sourceRectangle = new Rectangle(256, 11, 16, 16);
                    else
                        sourceRectangle = new Rectangle(273, 11, 16, 16);
                }
                else
                {
                    sourceRectangle = new Rectangle(239, 11, 16, 16);
                    if (currentFrame <= totalFrames / 2)
                        s = SpriteEffects.None;
                    else
                        s = SpriteEffects.FlipHorizontally;
                }
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, spriteColor, 0, Vector2.Zero, s, 0);
            spriteColor = Color.White;
            if (!trapFinished)
                trapFinished = trap.Draw(spriteBatch);
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
    }
}

