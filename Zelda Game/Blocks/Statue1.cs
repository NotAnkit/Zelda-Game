﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Statue1 : IEnvironment
    {
        private readonly Texture2D Texture;
        private Vector2 position;

        public Statue1(Texture2D texture)
        {
            Texture = texture;
        }

        public Rectangle BlockRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1018, 11, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
