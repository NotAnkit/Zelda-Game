using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class LinkWoodSwordLeftAnimation : ISprite
    {
  
        public Texture2D Texture;

        public LinkWoodSwordLeftAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        int currentFrame = 0;
        int totalFrames = 60;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 15)
            {
                sourceRectangle = new Rectangle(124, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else if (currentFrame == 30)
            {
                sourceRectangle = new Rectangle(18, 77, 27, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 54, 32);
            }
            else if (currentFrame == 45)
            {
                sourceRectangle = new Rectangle(46, 77, 23, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 46, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(70, 77, 19, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 38, 32);
            }
            //SpriteEffects s = SpriteEffects.FlipHorizontally;
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