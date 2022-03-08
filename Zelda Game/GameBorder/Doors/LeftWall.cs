using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LeftWall : IDoor
    {
        public Texture2D Texture;

        public LeftWall(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        public Rectangle doorRectangle()
        {
            return new Rectangle(0, 140, 63, 64);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(817, 44, 32, 32);
            Rectangle destinationRectangle = new Rectangle(0, 140, 63, 64);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
