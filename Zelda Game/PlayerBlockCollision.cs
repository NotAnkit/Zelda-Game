using System;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class PlayerBlockCollision
    {
        public PlayerBlockCollision()
        {
        }

        public String CollisionDirection(Rectangle linkRectangle, Rectangle blockRectangle)
        {
            String collisionType;
            Rectangle overlap = Rectangle.Intersect(linkRectangle, blockRectangle);
            if (overlap.IsEmpty)
            {
                collisionType = "none";
            }
            else if(overlap.Height > overlap.Width)
            {
                if(linkRectangle.X < blockRectangle.X)
                {
                    collisionType = "left-right";
                }
                else
                {
                    collisionType = "right-left";
                }
            }
            else {

                if (linkRectangle.Y > blockRectangle.Y)
                {
                    collisionType = "top-bottom";
                }
                else
                {
                    collisionType = "bottom-top";
                }
            }
            return collisionType;
        }
    }
}
