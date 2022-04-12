using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class BlueBoomerang : IItem
    {
        public Texture2D Texture;
        private Vector2 position;

        public BlueBoomerang(Texture2D texture)
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
            //134 28
            Rectangle sourceRectangle = new Rectangle(128, 18, 5, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 10, 32);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}