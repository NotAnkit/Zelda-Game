using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IEnvironment
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
