using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    /*currently stationary*/
    public class Dragon : IEnemy
    {
        public Texture2D Texture;
        private int windowHeight;
        private int windowWidth;

        public Dragon(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("EnemySheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(1, 10, 24, 32);
            Rectangle destinationRectangle = new Rectangle(windowWidth / 2, windowHeight / 2, 48, 64);

            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            
        }

    }
}

