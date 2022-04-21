using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class FireLeftAnimation : IProjectile
    {
        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X, (int)location.Y, 32, 32);
        }

        private readonly Texture2D Texture;
        private Vector2 location;
        private bool finished;

        public FireLeftAnimation(Texture2D texture)
        {
            Texture = texture;
            finished = false;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (startLocation.X - location.X <= 128)
            {
                sourceRectangle = new Rectangle(191, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(191, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
                finished = true;
            }

            if (location.X < 59)
            {
                finished = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;
        }

        public Vector2 Update(Vector2 position, Vector2 startPosition)
        {
            position.X--;
            location = position;
            return position;
        }

        public void SetFinished(bool finishedState)
        {
            finished = finishedState;
        }
    }
}