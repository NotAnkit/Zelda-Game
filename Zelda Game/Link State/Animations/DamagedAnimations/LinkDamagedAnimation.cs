using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class LinkDamagedAnimation : ISprite
    {
        public Texture2D Texture;

        public LinkDamagedAnimation(Texture2D texture, SoundEffect song)
        {
            Texture = texture;
            song.Play();
        }
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;


            sourceRectangle = new Rectangle(35, 232, 16, 16);
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 30, 30);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return location;
        }

        public void Update()
        {
        }
    }
}