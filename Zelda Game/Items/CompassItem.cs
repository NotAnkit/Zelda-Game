using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class CompassItem : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public CompassItem(Texture2D texture)
        {
            Texture = texture;
            
        }

        public Rectangle itemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 22, 24);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(258, 1, 11, 12);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 22, 24);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
