using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class GreenBoomerangDownAnimation : IProjectile
    {
        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X, (int)location.Y, 16, 32);
        }
        private Vector2 location;
        public Texture2D Texture;
        private bool flip;

        public GreenBoomerangDownAnimation(Texture2D texture, SoundEffect song)
        {
            Texture = texture;
            flip = false;
            song.Play();
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (startLocation.Y == location.Y && flip)
            {
                sourceRectangle = new Rectangle(82, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
                finished = true;
            }
            else if ((location.Y - startLocation.Y) % 18 <= 6)
            {
                sourceRectangle = new Rectangle(64, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else if ((location.Y - startLocation.Y) % 18 <= 9)
            {
                sourceRectangle = new Rectangle(73, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(82, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }

            if (location.Y > 253)
            {
                flip = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;

        }

        public Vector2 Update(Vector2 position, Vector2 startLocation)
        {
            if (position.Y - startLocation.Y <= 96 && !flip)
            {
                position.Y++;
            }
            else
            {
                flip = true;
                position.Y--;
            }
            location = position;
            return position;
        }
    }
}
