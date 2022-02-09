using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class LinkWoodSwordUpAnimation : ISprite
    {

    
        public Texture2D Texture;

        public LinkWoodSwordUpAnimation(Texture2D texture)
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
                sourceRectangle = new Rectangle(141, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else if (currentFrame == 30)
            {
                sourceRectangle = new Rectangle(18, 97, 16, 27);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 54);

            }
            else if (currentFrame == 45)
            {
                sourceRectangle = new Rectangle(35, 97, 16, 23);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 46);
            }
            else
            {
                sourceRectangle = new Rectangle(52, 97, 16, 19);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 38);
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
