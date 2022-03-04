using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IEnemy
    {
        void 
        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
    }
}
