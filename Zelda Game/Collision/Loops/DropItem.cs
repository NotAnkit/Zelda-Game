using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
namespace Zelda_Game.Collision.Loops
{
    public class DropItem
    {
        public DropItem()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 2);
            if (num == 1) //drop bomb
            {
                IItem drawBomb = ItemSpriteFactory.Instance.BombItem();
                //drawBomb.Draw(spriteBatch, location);

            }
            else //draw Rupee
            {
                IItem drawRupee = ItemSpriteFactory.Instance.RupeeItem();
                //drawRupee.Draw(spriteBatch, location);
            }
        }
    }
}
