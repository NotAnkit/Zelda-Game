using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game.LinkState
{
    public interface ILinkState
    {
        void ChangeDirection(string direction);
        void ChangeWeapon();
        void UseItem();
        void ThrowItem();
        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
    }
}
