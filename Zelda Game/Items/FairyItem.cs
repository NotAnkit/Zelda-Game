using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class FairyItem : IItem
    {
        public Texture2D Texture;

        public FairyItem(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
        }
        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(40, 0, 8, 16);
            Rectangle destinationRectangle = new Rectangle(625, 100, 16, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}