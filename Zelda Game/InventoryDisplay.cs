using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    /*not showing up???*/
    public class InventoryDisplay
    {
        public Texture2D Texture;
        public SpriteFont Font;
        private int windowHeight;
        private int windowWidth;

        public InventoryDisplay(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            //Font = game.Content.Load<SpriteFont>("SpriteFont");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            sourceRectangle = new Rectangle(0, 72, 8, 16);
            destinationRectangle = new Rectangle(59,60, 80, 160);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
