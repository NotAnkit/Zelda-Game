using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class HeartContainerItem : IItem
    {
        public Texture2D Texture;

        public HeartContainerItem(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
        }
        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(25, 1, 13, 13);
            Rectangle destinationRectangle = new Rectangle(625, 100, 26, 26);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
