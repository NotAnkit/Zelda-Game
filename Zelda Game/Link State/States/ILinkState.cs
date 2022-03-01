﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game.LinkState
{
    public interface ILinkState
    {
        void ChangeDirection(string direction);
        void ChangeWeapon();
        ISprite UseItem(string itemName);
        void Update();
        void UseSword();
        void TakeDamage();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
        Vector2 ChangePosition(Vector2 location);
    }
}
