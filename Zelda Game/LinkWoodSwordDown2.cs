﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class LinkWoodSwordDown2 : ISprite
    {
        public Texture2D Texture;
        private int windowHeight;
        private int windowWidth;

        public LinkWoodSwordDown2(Game1 game)
        {
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        public void Update()
        {
        }

        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location, Texture2D texture)
        {
            Rectangle sourceRectangle = new Rectangle(35, 47, 16, 23);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 23);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

            return location;
        }
    }
}