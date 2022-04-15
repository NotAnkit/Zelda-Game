using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class InventoryDisplay
    {
        private readonly Texture2D Texture;
        private Texture2D Texture2;
        private readonly SpriteFont Font;
        private LinkInventory inventory;
        private int rupees;
        private int keys;
        private int bombs;
        private int lives;
        private string itemA;
        private string itemB;

        public string ItemASlot
        {
            get => itemA;
            set => itemA = value;
        }
        public string ItemBSlot
        {
            get => itemB;
            set => itemB = value;
        }

        public InventoryDisplay(Game1 game, LinkInventory inventory)
        {
            Texture = game.Content.Load<Texture2D>("Inventory");
            Texture2 = game.Content.Load<Texture2D>("LinkSheet");
            Font = game.Content.Load<SpriteFont>("Display");
            this.inventory = inventory;
            itemA = "sword";
            itemB = "blank-projectile";
        }

        public void Update(Link player)
        {
            inventory = player.inventory;
            rupees = inventory.Rupees;
            keys = inventory.Keys;
            bombs = inventory.Bombs;
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

        public static void DrawLevel(SpriteBatch spriteBatch, int levelNum, SpriteFont font)
        {
            string output = "LEVEL-" + levelNum.ToString();
            Vector2 destination = new Vector2(20, 350);
            spriteBatch.DrawString(font, output, destination, Color.White);
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

        public static void DrawSelectionA(SpriteBatch spriteBatch, Texture2D texture)
        {
            Rectangle sourceRectangle = new Rectangle(552, 134, 12, 20);
            Rectangle destinationRectangle = new Rectangle(293, 380, 24, 40);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.Pink);
        }

        public void DrawSelectionB(SpriteBatch spriteBatch, Texture2D texture, string item)
        {
            Rectangle destinationRectangle = new Rectangle(250, 380, 16, 40);
            Rectangle sourceRectangle;
            if(!item.Equals("blank-projectile"))
            {
                if (item.Equals("blue-boomerang"))
                    sourceRectangle = new Rectangle(594, 134, 8, 20);
                else if (item.Equals("green-boomerang"))
                    sourceRectangle = new Rectangle(584, 134, 8, 20);
                else if (item.Equals("bow"))
                    sourceRectangle = new Rectangle(633, 134, 8, 20);
                else if (item.Equals("green-arrow"))
                    sourceRectangle = new Rectangle(617, 134, 8, 20);
                else if (item.Equals("blue-arrow"))
                    sourceRectangle = new Rectangle(626, 134, 8, 20);
                else if (item.Equals("fire"))
                {
                    texture = Texture2;
                    sourceRectangle = new Rectangle(191, 181, 16, 32); ;
                }
                else
                    sourceRectangle = new Rectangle(604, 134, 8, 20);
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
            DrawSelectionA(spriteBatch, Texture);
            DrawSelectionB(spriteBatch, Texture, itemB);
            DrawLevel(spriteBatch, 1, Font);
        }
    }
}
