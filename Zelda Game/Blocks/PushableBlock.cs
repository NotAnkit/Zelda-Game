using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class PushableBlock : IEnvironment
    {
        public Texture2D Texture;
        public Vector2 location;

        public PushableBlock(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        //public Rectangle PushableRectangle
        //{
        //    get { return new Rectangle((int)location.X, (int)location.Y, 32, 32); }
        //}

        public void Update()
        {      
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1001, 11, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }

    }
}
