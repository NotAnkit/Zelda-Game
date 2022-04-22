using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class LinkLeftDamage : ISprite
    {
        public Texture2D Texture;

        public LinkLeftDamage(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(35, 11, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 30, 30);
            SpriteEffects s = SpriteEffects.FlipHorizontally;


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.Red, 0, Vector2.Zero, s, 0);


            return location;
        }
    }
}