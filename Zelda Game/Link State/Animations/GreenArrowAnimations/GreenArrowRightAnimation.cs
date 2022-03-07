using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class GreenArrowRightAnimation : IProjectile
    {
        
        public Texture2D Texture;

        public GreenArrowRightAnimation(Texture2D texture)
        {
            Texture = texture;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            bool finished = false;

            if (location.X - startLocation.X <= 96)
            {
                sourceRectangle = new Rectangle(10, 185, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);
                finished = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;
        }

        public Vector2 Update(Vector2 position, Vector2 startPosition)
        {
            position.X++;
            return position;
        }
    }
}
