using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LoseScreen
    {
        private readonly Texture2D texture;

        public LoseScreen(Game1 game)
        {
            texture = game.Content.Load<Texture2D>("gameOverScreen");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 1366, 786);
            Rectangle destinationRectangle = new Rectangle(0, 0, 503, 445);

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {

        }
    }
}
