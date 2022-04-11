using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BorderBlock : IEnvironment
    {
        private readonly Texture2D Texture;
        private readonly Floor floor;

        public BorderBlock(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
            floor = new Floor(game);
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
            Rectangle sourceRectangle = new Rectangle(523, 11, 254, 176);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 503, 345);
            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            floor.Draw(spriteBatch, new Vector2(100, 100));
        }
    }
}
