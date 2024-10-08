﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class LinkDownIdle : ISprite
    {
        public Texture2D Texture;
        

        public LinkDownIdle(Texture2D texture)
        {
            Texture = texture;
        }

        public void Update()
        {
        }

        public Vector2 Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(1, 11, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 30, 30);

            
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
    

            return location;
        }
    }
}