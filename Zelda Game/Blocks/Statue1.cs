using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Statue1 : IEnvironment
    {
        public Texture2D Texture;
        private Vector2 position;

        public Statue1(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
            position = location;
        }

        public Rectangle blockRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1018, 11, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
