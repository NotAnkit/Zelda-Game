using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BombUpAnimation : IProjectile
    {

        public Texture2D Texture;

        public BombUpAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (startLocation.Y - location.Y <= 30)
            {
                sourceRectangle = new Rectangle(129, 185, 8, 16);
                destinationRectangle = new Rectangle((int)startLocation.X + 8, (int)startLocation.Y - 32, 16, 32);
            }
            else if (startLocation.Y - location.Y <= 40)
            {
                sourceRectangle = new Rectangle(138, 185, 16, 16);
                destinationRectangle = new Rectangle((int)startLocation.X, (int)startLocation.Y - 32, 32, 32);
            }
            else if (startLocation.Y - location.Y <= 50)
            {
                sourceRectangle = new Rectangle(155, 185, 16, 16);
                destinationRectangle = new Rectangle((int)startLocation.X, (int)startLocation.Y - 32, 32, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(172, 185, 16, 16);
                destinationRectangle = new Rectangle((int)startLocation.X, (int)startLocation.Y - 32, 32, 32);
                finished = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;
        }

        public Vector2 Update(Vector2 position, Vector2 startPosition)
        {
            position.Y--;
            return position;
        }
    }
}