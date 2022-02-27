using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class BorderBlock : IEnvironment
    {
        public Texture2D Texture;

        public BorderBlock(Game1 game)
        {
           
            Texture = game.Content.Load<Texture2D>("RoomSheet");
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(523, 11, 254, 176);
            Rectangle destinationRectangle = new Rectangle(0, 0, 792, 495);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
