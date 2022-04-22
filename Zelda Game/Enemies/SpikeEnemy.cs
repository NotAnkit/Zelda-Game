using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class SpikeEnemy : IEnemy
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
        private int movementCounter;
        private int num;
        private int count;

        public SpikeEnemy(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 30;
            spriteSpeed = 1f;
            windowHeight = game.WindowSizeHeight - 195;
            windowWidth = game.WindowSizeWidth - 97;
            position = location;
            health = 1;
            direction = "right";
            spriteColor = Color.White;
        }

        public Rectangle EnemyRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public Rectangle ProjectileRectangle(int num)
        {
            return new Rectangle(0, 0, 0, 0);
        }


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
            if (movementCounter == totalFrames * 2)
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
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

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
                sourceRectangle = new Rectangle(162, 59, 20, 16);
            }

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, spriteColor);
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
            Random rnd = new Random();
            int num = rnd.Next(1, 2);
            if (num == 1) //drop bomb
            {
                IItem drawBomb = ItemSpriteFactory.Instance.BombItem();
                //drawBomb.Draw(spriteBatch, location);

            }
            else //draw Rupee
            {
                IItem drawRupee = ItemSpriteFactory.Instance.RupeeItem();
                //drawRupee.Draw(spriteBatch, location);
            }
        }
    }
}
