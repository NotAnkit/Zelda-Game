using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class PlayerBlockCollision
    {
        public PlayerBlockCollision()
        {
        }

        public String Collision(Rectangle linkRectangle, Rectangle blockRectangle)
        {
            String collisionType = "none";
            Rectangle overlap = Rectangle.Intersect(linkRectangle, blockRectangle);
            if(overlap.Height > overlap.Width)
            {

            } else
            {

            }
            return collisionType;
        }
    }
}
