using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class BlueBoomerangLeftAnimation : IProjectile
    {
        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X, (int)location.Y, 16, 32);
        }
        private Vector2 location;
        public Texture2D Texture;
        private bool flip;
        private int speed;
        public BlueBoomerangLeftAnimation(Texture2D texture)
        {
            Texture = texture;
            flip = false;
            speed = 2;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (startLocation.X == location.X && flip)
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
                finished = true;
            }
            else if ((startLocation.X - location.X) % 18 <= 6)
            {
                sourceRectangle = new Rectangle(91, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
            }
            else if ((startLocation.X - location.X) % 18 <= 9)
            {
                sourceRectangle = new Rectangle(100, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(109, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
            }

            if (location.X < 59)
            {
                flip = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;

        }

        public Vector2 Update(Vector2 position, Vector2 startLocation)
        {
            if (startLocation.X - position.X <= 160 && !flip)
            {
                position.X -= speed;
            }
            else
            {
                flip = true;
                position.X += speed;
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
