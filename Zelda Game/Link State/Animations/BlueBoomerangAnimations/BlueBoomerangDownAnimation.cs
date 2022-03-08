using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BlueBoomerangDownAnimation : IProjectile
    {

        public Texture2D Texture;
        private bool flip;
        public BlueBoomerangDownAnimation(Texture2D texture)
        {
            Texture = texture;
            flip = false;
        }

        
        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (startLocation.Y == location.Y && flip)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
                finished = true;
            }
            else if ((location.Y - startLocation.Y) % 18 <= 6)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else if ((location.Y - startLocation.Y) % 18 <= 9)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;

        }

        public Vector2 Update(Vector2 location, Vector2 startLocation)
        {
            if (location.Y - startLocation.Y <= 160 && !flip)
            {
                location.Y++;
            }
            else
            {
                flip = true;
                location.Y--;
            }
            return location;
        }
    }
}