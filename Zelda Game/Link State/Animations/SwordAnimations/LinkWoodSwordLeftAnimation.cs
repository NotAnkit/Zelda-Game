using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class LinkWoodSwordLeftAnimation : ISprite
    {
  
        public Texture2D Texture;
        public SoundEffect song;

        public LinkWoodSwordLeftAnimation(Texture2D texture, SoundEffect Song)
        {
            Texture = texture;
            song = Song;
            song.Play();
        }

        private int currentFrame = 0;
        private readonly int totalFrames = 30;
        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame <= 7)
            {
                sourceRectangle = new Rectangle(124, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 15)
            {
                sourceRectangle = new Rectangle(18, 77, 27, 16);
                destinationRectangle = new Rectangle((int)location.X-24, (int)location.Y, 54, 32);
            }
            else if (currentFrame <= 22)
            {
                sourceRectangle = new Rectangle(46, 77, 23, 16);
                destinationRectangle = new Rectangle((int)location.X-16, (int)location.Y, 46, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(70, 77, 23, 16);
                destinationRectangle = new Rectangle((int)location.X-16, (int)location.Y, 46, 32);
            }

            SpriteEffects s = SpriteEffects.FlipHorizontally;
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, Vector2.Zero, s, 0);
            return location;
        }

        public void Update()
        {

            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
}