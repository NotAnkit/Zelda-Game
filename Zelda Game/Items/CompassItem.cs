using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class CompassItem : IItem
    {
        public Texture2D Texture;

        public CompassItem(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
        }
        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(258, 1, 11, 12);
            Rectangle destinationRectangle = new Rectangle(625, 100, 22, 24);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
