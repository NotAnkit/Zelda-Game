using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    public class LinkUpAnimation : ISprite
    {
        private int windowHeight;
        private int windowWidth;
        public Texture2D Texture;

        public LinkUpAnimation(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        int currentFrame = 0;
        int totalFrames = 2;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(69, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 16);
            }
            else
            {
                sourceRectangle = new Rectangle(86, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 16);
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return location;
        }



        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
}
