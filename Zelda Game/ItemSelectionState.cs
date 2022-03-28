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
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            //Font = game.Content.Load<SpriteFont>("SpriteFont");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, SpriteFont font)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            sourceRectangle = new Rectangle(0, 72, 8, 16);
            destinationRectangle = new Rectangle(59, 60, 80, 160);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.DrawString(font, "INVENTORY", new Vector2(150, 150), Color.Red);
            spriteBatch.DrawString(font, "USE B BUTTON", new Vector2(150, 300), Color.White);
            spriteBatch.DrawString(font, "FOR THIS", new Vector2(150, 300), Color.White);
            spriteBatch.DrawString(font, "LEVEL-1", new Vector2(150, 500), Color.White);
            spriteBatch.DrawString(font, "-LIFE-", new Vector2(400, 400), Color.Red);
        }
    }
}
