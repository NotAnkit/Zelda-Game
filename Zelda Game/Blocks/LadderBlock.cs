using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class LadderBlock : IEnvironment
    {
        public Texture2D Texture;
        private Vector2 position;

        public LadderBlock(Game1 game, Vector2 location)
        {
            Texture = game.Content.Load<Texture2D>("RoomSheet");
            position = location;
        }

        public Rectangle LadderBlockRectangle
        {
            get { return new Rectangle((int)position.X, (int)position.Y, 32, 32); }
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1001, 45, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}