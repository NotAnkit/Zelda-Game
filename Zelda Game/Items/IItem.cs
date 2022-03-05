using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IItem
    {
        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
        Rectangle itemRectangle();
    }
}