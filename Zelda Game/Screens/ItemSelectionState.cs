using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class ItemSelectionState
    {
        public Texture2D Texture;
        public SpriteFont Font;
        private int windowHeight;
        private int windowWidth;

        public ItemSelectionState(Game1 game)
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
            Rectangle sourceRectangle = new Rectangle(1, 11, 256, 88);
            Rectangle sourceRectangle2 = new Rectangle(258, 112, 256, 88);
            //Rectangle sourceRectangle3 = new Rectangle(88, 0, 8, 16); // For Map Item
            //Rectangle sourceRectangle3 = new Rectangle(275, 11, 256, 56);
            Rectangle destinationRectangle = new Rectangle(0, 20, 448, 154);
            Rectangle destinationRectangle2 = new Rectangle(0, 182, 448, 154);
            //Rectangle destinationRectangle3 = new Rectangle(20, 20, 16, 32); // For Map Item
            //Rectangle destinationRectangle3 = new Rectangle(50, 314, 384, 84);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.Draw(Texture, destinationRectangle2, sourceRectangle2, Color.White);
            //spriteBatch.Draw(Texture, destinationRectangle3, sourceRectangle3, Color.White);
            //spriteBatch.DrawString(font, "INVENTORY", new Vector2(150, 150), Color.Red);
            //spriteBatch.DrawString(font, "USE B BUTTON", new Vector2(150, 300), Color.White);
            //spriteBatch.DrawString(font, "FOR THIS", new Vector2(150, 300), Color.White);
            //spriteBatch.DrawString(font, "LEVEL-1", new Vector2(150, 500), Color.White);
            //spriteBatch.DrawString(font, "-LIFE-", new Vector2(400, 400), Color.Red);
        }
    }
}
