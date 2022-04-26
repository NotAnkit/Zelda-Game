using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Boss : IEnemy
    {
        private readonly Game1 Game;
        private readonly Texture2D Texture;
        private int currentFrame;
        private readonly int totalFrames;
        private float spriteSpeed;
        private readonly int windowHeight;
        private readonly int windowWidth;
        private Vector2 position;
        public Fireballs fireballs;
        private string direction;
        private int health;
        private Color spriteColor;
        private int count;

        public Rectangle EnemyRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 48, 64);
        }

        public Rectangle ProjectileRectangle(int num)
        {
            return fireballs.EnemyRectangle(num);
        }

        public Boss(Game1 game, Vector2 location)
        {
            Game = game;
            Texture = game.Content.Load<Texture2D>("EnemySheet");
            currentFrame = 0;
            totalFrames = 60;
            spriteSpeed = 0f;
            health = 10;
            windowHeight = game.WindowSizeHeight - 195;
            windowWidth = game.WindowSizeWidth - 81;
            position = location;
            fireballs = new Fireballs(game, new Vector2(position.X, position.Y));
            direction = "right";
            spriteColor = Color.White;
        }

        private int movementCounter = 0;
        private int num = 0;
        public void Update()
        {
            if (count < 20)
            {
                count++;
            }

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

            if (num % 2 == 0)
            {
                position.X += spriteSpeed;
                if (position.X > windowWidth - 24)
                    position.X -= spriteSpeed;
                direction = "right";
            }
            else
            {
                position.X -= spriteSpeed;
                if (position.X < 59)
                    position.X += spriteSpeed;
                direction = "left";
                if (movementCounter == 0)
                    fireballs = new Fireballs(Game, position);
            }
            fireballs.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 48, 64);

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
                if (currentFrame <= totalFrames / 4)
                {
                    sourceRectangle = new Rectangle(40, 154, 32, 32);
                    if (health <= 5)
                    {
                        spriteColor = Color.Brown;
                    }
                }
                else if (currentFrame > totalFrames / 4 && currentFrame <= totalFrames / 2)
                {

                    sourceRectangle = new Rectangle(106, 154, 32, 32);
                    if (health <= 5)
                    {
                        spriteColor = Color.Brown;
                    }
                }
                else if (currentFrame > totalFrames / 2 && currentFrame <= 3 * totalFrames / 4)
                {
                    sourceRectangle = new Rectangle(139, 154, 32, 32);
                    if (health <= 5)
                    {
                        spriteColor = Color.Brown;
                    }
                }
                else
                    sourceRectangle = new Rectangle(172, 154, 32, 32);
                    if (health <= 5)
                    {
                        spriteColor = Color.Brown;
                    }
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, spriteColor);
            spriteColor = Color.White;
            fireballs.Draw(spriteBatch);
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

