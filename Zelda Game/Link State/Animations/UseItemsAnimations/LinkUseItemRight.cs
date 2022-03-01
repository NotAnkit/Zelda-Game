using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class LinkUseItemRight : ISprite
    {
        public Texture2D Texture;
   

        public LinkUseItemRight(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(124, 11, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
          

            return location;
        }
    }
}