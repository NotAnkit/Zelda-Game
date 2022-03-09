using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Zelda_Game
{
    public class BlueArrowUpAnimation : IProjectile
    {

        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X, (int)location.Y, 16, 32);
        }

        public Texture2D Texture;
        public Vector2 location;

        public BlueArrowUpAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (startLocation.Y - location.Y <= 160)
            {
                sourceRectangle = new Rectangle(27, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
                finished = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;
        }

        public Vector2 Update(Vector2 position, Vector2 startPosition)
        {
            position.Y--;
            location = position;
            return position;
        }
    }
}