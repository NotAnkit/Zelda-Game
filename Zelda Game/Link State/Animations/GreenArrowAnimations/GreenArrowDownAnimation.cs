using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class GreenArrowDownAnimation : IProjectile
    {
        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X + 8, (int)location.Y + 32, 1, 1);
        }

        private readonly Texture2D Texture;
        private Vector2 location;
        private bool finished;

        public GreenArrowDownAnimation(Texture2D texture)
        {
            Texture = texture;
            finished = false;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (location.Y - startLocation.Y <= 96)
            {
                sourceRectangle = new Rectangle(1, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
                finished = true;
            }

            if (location.Y > 253)
            {
                finished = true;
            }

            SpriteEffects s = SpriteEffects.FlipVertically;
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, Vector2.Zero, s, 0);
            return finished;
        }

        public Vector2 Update(Vector2 position, Vector2 startPosition)
        {
            position.Y++;
            location = position;
            return position;
        }

        public void SetFinished(bool finishedState)
        {
            finished = finishedState;
        }
    }
}