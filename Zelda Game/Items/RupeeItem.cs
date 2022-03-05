using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class RupeeItem : IItem
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private Vector2 position;

        public RupeeItem(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            position = location;
            currentFrame = 0;
            totalFrames = 30;
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 16, 32);

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(72, 16, 8, 16);
                
            else
                sourceRectangle = new Rectangle(72, 0, 8, 16);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
