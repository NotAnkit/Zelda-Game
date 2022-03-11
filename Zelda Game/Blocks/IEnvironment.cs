using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IEnvironment
    {
        Rectangle BlockRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
    }
}
