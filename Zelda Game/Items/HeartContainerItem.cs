using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class HeartContainerItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public HeartContainerItem(Texture2D texture)
        {
            Texture = texture;
            
        }

        public Rectangle itemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 26, 26);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(25, 1, 13, 13);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 26, 26);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
