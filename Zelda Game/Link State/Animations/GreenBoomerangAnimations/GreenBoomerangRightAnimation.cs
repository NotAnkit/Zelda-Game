using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class GreenBoomerangRightAnimation : IProjectile
    {

        public Texture2D Texture;
        private bool flip;

        public GreenBoomerangRightAnimation(Texture2D texture)
        {
            Texture = texture;
            flip = false;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (startLocation.X == location.X && flip)
            {
                sourceRectangle = new Rectangle(82, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
                finished = true;
            }
            else if ((location.X - startLocation.X) % 18 <= 6)
            {
                sourceRectangle = new Rectangle(64, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
            }
            else if ((location.X - startLocation.X) % 18 <= 9)
            {
                sourceRectangle = new Rectangle(73, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(82, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
            }


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;

        }

        public Vector2 Update(Vector2 location, Vector2 startLocation)
        {
            if (location.X - startLocation.X <= 96 && !flip)
            {
                location.X++;
            }
            else
            {
                flip = true;
                location.X--;
            }
            return location;
        }
    }
}
