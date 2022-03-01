using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class HeartItem : IItem
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;

        public HeartItem(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
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
            Rectangle destinationRectangle = new Rectangle(625, 100, 14, 16);

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(0, 8, 7, 8);

            else
                sourceRectangle = new Rectangle(0, 0, 7, 8);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
