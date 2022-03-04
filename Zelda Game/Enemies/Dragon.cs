using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Dragon : IEnemy
    {
        private Game1 Game;
        private Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;
        private Fireballs fireballs;

        public Rectangle enemyRectangle
        {
            get { return new Rectangle((int)position.X, (int)position.Y, 32, 32); }
        }

        public Dragon(Game1 game, Vector2 location)
        {
            Game = game;
            Texture = game.Content.Load<Texture2D>("EnemySheet");
            currentFrame = 0;
            totalFrames = 60;
            spriteSpeed = 1f;
            windowHeight = game._graphics.PreferredBackBufferHeight - 230;
            windowWidth = game._graphics.PreferredBackBufferWidth - 380;
            position = location;
            fireballs = new Fireballs(game, new Vector2(position.X, position.Y));
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

            if (num % 2 == 0)
            {
                position.X += spriteSpeed;
                if (position.X > windowWidth - 24)
                    position.X -= spriteSpeed;
            }
            else
            {
                position.X -= spriteSpeed;
                if (position.X < 59)
                    position.X += spriteSpeed;
                if (movementCounter == 0)
                    fireballs = new Fireballs(Game, position);
            }
            fireballs.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 48, 64);

            if (currentFrame <= totalFrames / 4)
                sourceRectangle = new Rectangle(1, 11, 24, 32);
            else if(currentFrame > totalFrames / 4 && currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(26, 11, 24, 32);
            else if(currentFrame > totalFrames / 2 && currentFrame <= 3 * totalFrames / 4)
                sourceRectangle = new Rectangle(51, 11, 24, 32);
            else
                sourceRectangle = new Rectangle(76, 11, 24, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            fireballs.Draw(spriteBatch);
        }

    }
}

