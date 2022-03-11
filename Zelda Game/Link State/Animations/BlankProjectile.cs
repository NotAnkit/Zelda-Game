using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BlankProjectile : IProjectile
    {
        public BlankProjectile()
        {
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startPosition)
        {
            return true;
        }

        public Rectangle ProjectileRectangle()
        {
            return new Rectangle(0, 0, 0, 0);
        }

        public Vector2 Update(Vector2 location, Vector2 startPosition)
        {
            return location;
        }
    }
}
