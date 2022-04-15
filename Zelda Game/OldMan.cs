using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class OldMan : IEnvironment
    {
        private readonly Texture2D Texture;
        private Vector2 position;
        private readonly SpriteFont Font;

        public OldMan(Texture2D texture, SpriteFont font)
        {
            Texture = texture;
            Font = font;
        }

        public Rectangle BlockRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(8, 4, 30, 44);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 30, 44);
            position = location;

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            Vector2 destination = new Vector2(60, 100);
            spriteBatch.DrawString(Font, "EASTMOST PENINSULA IS THE SECRET", destination, Color.White);

        }
    }
}