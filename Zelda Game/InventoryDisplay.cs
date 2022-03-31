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
            Texture = game.Content.Load<Texture2D>("Inventory");
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
            sourceRectangle = new Rectangle(258, 11, 256, 56);
            destinationRectangle = new Rectangle(0, 345, 448, 98);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.Pink); //gem
        }
    }
}
