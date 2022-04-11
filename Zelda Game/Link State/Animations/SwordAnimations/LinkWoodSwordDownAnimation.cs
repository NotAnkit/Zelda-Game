using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class LinkWoodSwordDownAnimation : ISprite
    {
      
        public Texture2D Texture;
        public SoundEffect song;

        public LinkWoodSwordDownAnimation(Texture2D texture, SoundEffect Song)
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
                sourceRectangle = new Rectangle(107, 11, 16, 16);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 32);
            }
            else if (currentFrame <= 15)
            {
                sourceRectangle = new Rectangle(18, 47, 16, 27);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 54);
            }
            else if (currentFrame <= 22)
            {
                sourceRectangle = new Rectangle(35, 47, 16, 23);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 46);
            }
            else
            {
                sourceRectangle = new Rectangle(52, 47, 16, 19);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 32, 38);
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
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