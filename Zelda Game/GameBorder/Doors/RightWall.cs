using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class RightWall : IDoor
    {
        public Texture2D Texture;

        public RightWall(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        public Rectangle DoorRectangle()
        {
            return new Rectangle(438, 141, 65, 63);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(815, 77, 32, 32);
            Rectangle destinationRectangle = new Rectangle(438, 141, 65, 63);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
