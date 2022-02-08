using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class LinkWoodSwordUpAnimation : ISprite
    {

        private int windowHeight;
        private int windowWidth;
        public Texture2D Texture;

        public LinkWoodSwordUpAnimation(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        int currentFrame = 0;
        int totalFrames = 4;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(141, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 16);
            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(18, 97, 16, 27);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 27);

            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(35, 97, 16, 23);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 23);
            }
            else
            {
                sourceRectangle = new Rectangle(52, 97, 16, 19);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 19);
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return location;
        }

        public void draw(SpriteBatch spriteBatch, Vector2 location, SpriteFont font)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
}
