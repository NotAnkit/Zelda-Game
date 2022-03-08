using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class RightKey : IDoor
    {
        public Texture2D Texture;

        public RightKey(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        public Rectangle doorRectangle()
        {
            return new Rectangle(438, 141, 64, 63);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(880, 77, 32, 32);
            Rectangle destinationRectangle = new Rectangle(438, 141, 64, 63);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
