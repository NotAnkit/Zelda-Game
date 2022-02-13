using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class CompassItem : IItem
    {
        public Texture2D Texture;
        private int windowHeight;
        private int windowWidth;

        public CompassItem(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }
        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(258, 1, 11, 12);
            Rectangle destinationRectangle = new Rectangle(0, 0, 32, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
