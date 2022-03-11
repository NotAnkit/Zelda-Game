using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IProjectile
    {
        Rectangle ProjectileRectangle();
        public Vector2 Update(Vector2 location, Vector2 startPosition);
        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startPosition);
    }
}
