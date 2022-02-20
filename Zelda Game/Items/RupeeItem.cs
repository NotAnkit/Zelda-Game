using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class RupeeItem : IItem
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private int windowHeight;
        private int windowWidth;

        public RupeeItem(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            currentFrame = 0;
            totalFrames = 30;
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle(625, 100, 16, 32);

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(72, 16, 8, 16);
                
            else
                sourceRectangle = new Rectangle(72, 0, 8, 16);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
