using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IDoor
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch, Vector2 location);
        Rectangle DoorRectangle();
    }
}
