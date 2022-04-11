using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IEnemyProjectile
    {
        void Update();
        bool Draw(SpriteBatch spriteBatch);
    }
}
