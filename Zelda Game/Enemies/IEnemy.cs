using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IEnemy
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
