using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class BlackBlock : IEnvironment
    {
        public Texture2D Texture;
        private int windowHeight;
        private int windowWidth;

        public BlackBlock(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(984, 28, 16, 16);
            Rectangle destinationRectangle = new Rectangle(100, 100, 32, 32);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}