using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LeftDoor : IDoor
    {
        public Texture2D Texture;

        public LeftDoor(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        public Rectangle DoorRectangle()
        {
            return new Rectangle(0, 170, 60, 5);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(848, 44, 32, 32);
            Rectangle destinationRectangle = new Rectangle(0, 140, 63, 64);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
