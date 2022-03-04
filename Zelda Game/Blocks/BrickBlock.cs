using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class BrickBlock : IEnvironment
    {
        public Texture2D Texture;
        private Vector2 position;

        public BrickBlock(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
            position = location;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(984, 45, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}