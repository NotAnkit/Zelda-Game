﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public interface IEnemy
    {
        Rectangle enemyRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
    }
}
