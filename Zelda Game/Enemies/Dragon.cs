using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class Dragon : IEnemy
    {
        public Texture2D Texture;
        private Game1 game;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;
        public Fireballs fireballs;

        public Dragon(Game1 game)
        {
            this.game = game;
            Texture = game.Content.Load<Texture2D>("EnemySheet");
            currentFrame = 0;
            totalFrames = 60;
            spriteSpeed = 1f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position = new Vector2(windowWidth / 2, windowHeight / 2);
            fireballs = new Fireballs(game, new Vector2(position.X, position.Y));
        }

        int movementCounter = 0;
        int num = 0;
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
                if (position.X > windowWidth)
                    position.X = 0;
            }
            else
            {
                position.X -= spriteSpeed;
                if (position.X < 0)
                    position.X = windowWidth;
            }
            fireballs.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
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

