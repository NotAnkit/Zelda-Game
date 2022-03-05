using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class ClockItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public ClockItem(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            position = location;
        }
        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(58, 0, 11, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 22, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}