using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BottomDoor : IDoor
    {
        public Texture2D Texture;

        public BottomDoor(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(848, 110, 32, 32);
            Rectangle destinationRectangle = new Rectangle(217, 282, 65, 63);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
