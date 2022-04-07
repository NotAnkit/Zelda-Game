﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Zelda_Game
{
    public class BlueArrowUpAnimation : IProjectile
    {

        public Rectangle ProjectileRectangle()
        {
            return new Rectangle((int)location.X+8, (int)location.Y-16, 1, 1);
        }

        private Texture2D Texture;
        private Vector2 location;
        private bool finished;

        public BlueArrowUpAnimation(Texture2D texture, SoundEffect song)
        {
            Texture = texture;
            song.Play();
            finished = false;
        }

        public bool Draw(SpriteBatch spriteBatch, Vector2 location, Vector2 startLocation)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            

            if (startLocation.Y - location.Y <= 160)
            {
                sourceRectangle = new Rectangle(27, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
            }
            else
            {
                sourceRectangle = new Rectangle(53, 185, 8, 16);
                destinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y, 16, 32);
                finished = true;
            }

            if (location.Y < 61)
            {
                finished = true;
            }

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            return finished;
        }

        public Vector2 Update(Vector2 position, Vector2 startPosition)
        {
            position.Y--;
            location = position;
            return position;
        }

        public void SetFinished(bool finishedState)
        {
            finished = finishedState;
        }
    }
}