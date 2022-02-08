using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface ISprite
    {
        public void Update();

        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location);
    }
}
