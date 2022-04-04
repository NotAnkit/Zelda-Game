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
        private int keys;
        private int bombs;
        private int lives;

        public InventoryDisplay(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("Inventory");
            Font = game.Content.Load<SpriteFont>("Display");
            windowHeight = game._graphics.PreferredBackBufferHeight-100;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            inventory = new LinkInventory();
        }

        public void Update()
        {
            rupees = inventory.NumRupees();
            keys = inventory.NumKeys();
            bombs = inventory.NumBombs();
            lives = inventory.NumLives();
        }

        public static void DrawBlackout(SpriteBatch spriteBatch, Texture2D texture)
        {
            Rectangle sourceRectangle= new Rectangle(2, 12, 24, 8);
            Rectangle destinationRectangle;
            destinationRectangle = new Rectangle(188, 367, 50, 20);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.Pink);
            destinationRectangle = new Rectangle(189, 397, 50, 40);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.Pink);
            destinationRectangle = new Rectangle(335, 400, 200, 160);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.Pink);
        }

        public static void DrawRupees(SpriteBatch spriteBatch, int numRupees, SpriteFont font)
        {
            string output = "X" + numRupees.ToString();
            Vector2 destination = new Vector2(193, 369);
            spriteBatch.DrawString(font, output, destination, Color.Red);
        }

        public static void DrawKeys(SpriteBatch spriteBatch, int numKeys, SpriteFont font)
        {
            string output = "X" + numKeys.ToString();
            Vector2 destination = new Vector2(193, 397);
            spriteBatch.DrawString(font, output, destination, Color.Red);
        }

        public static void DrawBombs(SpriteBatch spriteBatch, int numBombs, SpriteFont font)
        {
            string output = "X" + numBombs.ToString();
            Vector2 destination = new Vector2(193, 414);
            spriteBatch.DrawString(font, output, destination, Color.Red);
        }

        public static void DrawLives(SpriteBatch spriteBatch, int numLives, Texture2D texture)
        {
            Rectangle sourceRectangle = new Rectangle(645, 117, 8, 8);
            Rectangle destinationRectangle;
            for(int i=0; i<numLives; i++)
            {
                destinationRectangle = new Rectangle(345+(32*i), 405, 24, 24);
                spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.Pink);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(258, 11, 256, 56);
            Rectangle destinationRectangle = new Rectangle(0, 345, 503, 100);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.Pink);
            DrawBlackout(spriteBatch, Texture);
            DrawRupees(spriteBatch, rupees, Font);
            DrawKeys(spriteBatch, keys, Font);
            DrawBombs(spriteBatch, bombs, Font);
            DrawLives(spriteBatch, lives, Texture);
        }
    }
}
