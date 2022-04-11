using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class PushableBlock : IEnvironment
    {
        private readonly Texture2D Texture;
        public Vector2 position;

        public PushableBlock(Texture2D texture, Vector2 position)
        {
            this.position = position;
            Texture = texture;
        }

        public Rectangle BlockRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1001, 11, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }

    }
}
