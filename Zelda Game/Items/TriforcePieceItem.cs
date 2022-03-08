using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class TriforcePieceItem : IItem
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private Vector2 position;

        public TriforcePieceItem(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("WeaponSheet");
            position = location;
            currentFrame = 0;
            totalFrames = 30;
        }

        public Rectangle itemRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 20, 20);
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle; //= new Rectangle(275, 3, 10, 10);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 20, 20);

            if (currentFrame <= totalFrames / 2)
                sourceRectangle = new Rectangle(275, 19, 10, 10);
            else
                sourceRectangle = new Rectangle(275, 3, 10, 10);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}

