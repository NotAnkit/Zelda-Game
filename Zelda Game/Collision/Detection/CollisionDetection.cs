using System;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class CollisionDetection
    {

        public static String getDirection(Rectangle rec1, Rectangle rec2)
        {
            String collisionType;
            Rectangle overlap = Rectangle.Intersect(rec1, rec2);
            if (overlap.IsEmpty)
            {
                collisionType = "none";
            }
            else if(overlap.Height > overlap.Width)
            {
                if(rec1.X < rec2.X)
                {
                    collisionType = "left-right";
                }
                else
                {
                    collisionType = "right-left";
                }
            }
            else {

                if (rec1.Y > rec2.Y)
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
