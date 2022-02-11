﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    /*needs state implementation*/
    public class Goriya : IEnemy
    {
        public Texture2D Texture;
        private int windowHeight;
        private int windowWidth;

        public Goriya(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(220, 10, 16, 16);
            Rectangle destinationRectangle = new Rectangle(windowWidth / 2, windowHeight / 2, 32, 32);

            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            
        }

    }
}

