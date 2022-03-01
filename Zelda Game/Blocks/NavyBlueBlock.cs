using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class NavyBlueBlock : IEnvironment
    {
        public Texture2D Texture;

        public NavyBlueBlock(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1018, 28, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}