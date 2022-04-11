using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class BlueBoomerangUpAnimation : IProjectile
    {
        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X, (int)location.Y, 16, 32);
        }
        private Vector2 location;
        public Texture2D Texture;
        private bool flip;
        public BlueBoomerangUpAnimation(Texture2D texture, SoundEffect song)
        {
            Texture = texture;
            song.Play();
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
            else if ((startLocation.Y - location.Y) % 18 <= 6)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else if ((startLocation.Y - location.Y) % 18 <= 9)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }

            if (location.Y < 61)
            {
                flip = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;

        }

        public Vector2 Update(Vector2 position, Vector2 startLocation)
        {
            if (startLocation.Y - position.Y <= 160 && !flip)
            {
                position.Y--;
            }
            else
            {
                flip = true;
                position.Y++;
            }
            location = position;
            return position;
        }

        public void SetFinished(bool finishedState)
        {
            flip = finishedState;
        }
    }
}
