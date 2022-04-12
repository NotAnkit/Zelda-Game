using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BasementBlock : IEnvironment
    {
        private Texture2D Texture;

        public BasementBlock(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");

        }

        public Rectangle BlockRectangle()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(421, 1008, 256, 160);
            Rectangle destinationRectangle = new Rectangle(0, 0, 512, 320);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
