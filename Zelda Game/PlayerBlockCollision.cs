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
            if (overlap.IsEmpty)
            {
                //no collision
            }
            else if(overlap.Height > overlap.Width)
            {
                if(linkRectangle.X < blockRectangle.X)
                {
                    //left-right
                }
                else
                {
                    //right-left
                }
            }
            else {

                if (linkRectangle.Y > blockRectangle.Y)
                {
                    //top-bottom
                }
                else
                {
                    //bottom-top
                }
            }
            return collisionType;
        }
    }
}
