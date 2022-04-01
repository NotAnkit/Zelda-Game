using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class InventoryDisplay
    {
        public Texture2D Texture;
        public SpriteFont Font;
        private int windowHeight;
        private int windowWidth;
        private LinkInventory inventory;
        private int rupees;

        public InventoryDisplay(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("Inventory");
            Font = game.Content.Load<SpriteFont>("Display");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            inventory = new LinkInventory();
        }

        public void Update()
        {
            rupees = inventory.NumRupees();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            sourceRectangle = new Rectangle(258, 11, 256, 56);
            destinationRectangle = new Rectangle(0, 345, 503, 100);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.Pink);
        }
    }
}
