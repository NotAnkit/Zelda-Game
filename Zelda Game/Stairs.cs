﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Stairs : IEnvironment
    {
        public Texture2D Texture;
        private int windowHeight;
        private int windowWidth;

        public Stairs(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(1035, 28, 16, 16);
            Rectangle destinationRectangle = new Rectangle(100, 100, 35, 35);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
