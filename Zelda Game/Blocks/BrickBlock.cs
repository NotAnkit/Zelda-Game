﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BrickBlock : IEnvironment
    {
        private readonly Texture2D Texture;
        private Vector2 position;

        public BrickBlock(Texture2D texture)
        {
            Texture = texture;
        }

        public Rectangle BlockRectangle()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(984, 45, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}