using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Zelda_Game
{
    class MovingNonAnimated : ISprite
    {
        Vector2 _location;
        public void draw(SpriteBatch spriteBatch, Vector2 location, SpriteFont font)
        {
            throw new NotImplementedException();
        }

        public Vector2 draw(SpriteBatch spriteBatch, Vector2 location, Texture2D texture)
        {
            Rectangle sourceRectangle = new Rectangle(9, 4, 35, 49);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 35, 49);

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            location.Y -= 1;
            if (location.Y <= 0)
            {
                location.Y = 400;
            }
            return _location = location;
        }

        public void update()
        {

        }
    }
}
