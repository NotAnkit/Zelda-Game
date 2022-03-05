﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class CompassItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public CompassItem(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            position = location;
        }
        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(258, 1, 11, 12);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 22, 24);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
