using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class BigBlackBlock : IEnvironment
    {
        private readonly Texture2D Texture;
        private Vector2 position;

        public BigBlackBlock(Texture2D texture)
        {
            Texture = texture;
        }


        public Rectangle BlockRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 384, 224);
        }


        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(984, 28, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 384, 224);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}