using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class FireItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public FireItem(Texture2D texture)
        {
            Texture = texture;
        }

        public Rectangle ItemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 10, 32);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(191, 181, 16, 32);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 64);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}