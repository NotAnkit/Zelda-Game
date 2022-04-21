using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class WinScreen
    {
        private Texture2D texture;

        public WinScreen(Game1 game)
        {
            texture = game.Content.Load<Texture2D>("victoryScreen");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 1200, 675);
            Rectangle destinationRectangle = new Rectangle(0, 0, 503, 445);

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {

        }
    }
}
