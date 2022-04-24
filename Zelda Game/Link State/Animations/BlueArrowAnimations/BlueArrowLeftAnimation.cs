using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BlueArrowLeftAnimation : IProjectile
    {

        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X, (int)location.Y+8, 1, 1);
        }

        private readonly Texture2D Texture;
        private Vector2 location;
        private bool finished;
        private readonly int speed;

        public BlueArrowLeftAnimation(Texture2D texture)
        {
            Texture = texture;
            finished = false;
            speed = 2;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if(startLocation.X - location.X <= 160)
            {
                sourceRectangle = new Rectangle(36, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X-16, (int)location.Y, 16, 32);
                finished = true;
            }

            if (location.X < 59)
            {
                finished = true;
            }

            SpriteEffects s = SpriteEffects.FlipHorizontally;
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, Vector2.Zero, s, 0);
            return finished;
        }

        public Vector2 Update(Vector2 position, Vector2 startPosition)
        {
            position.X -= speed;
            location = position;
            return position;
        }

        public void SetFinished(bool finishedState)
        {
            finished = finishedState;
        }
    }
}