using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IEnemy
    {
        Rectangle EnemyRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
        void SetSpeed(float speed);
        string GetDirection();
        void DecreaseHealth();
        int Health();
    }
}
