using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class ArrowItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public ArrowItem(Texture2D texture)
        {
            Texture = texture;   
        }

        public Rectangle itemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 10, 32);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(154, 0, 5, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 10, 32);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
