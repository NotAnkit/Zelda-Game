using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class ClockItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public ClockItem(Texture2D texture)
        {
            Texture = texture;
            
        }

        public Rectangle ItemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 22, 32);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(58, 0, 11, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 22, 32);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}