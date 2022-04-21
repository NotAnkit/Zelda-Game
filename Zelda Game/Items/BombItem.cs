using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class BombItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public BombItem(Texture2D texture)
        {
            Texture = texture;
            
        }
        public Rectangle ItemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 16, 28);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(136, 0, 7, 14);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 28);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
