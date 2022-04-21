using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class DropItem
    {
        public static void EnemyDrop(Dictionary<Vector2, IItem> items, Vector2 position)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 8);
            if (num == 1) 
            {
                items.Add(position, ItemSpriteFactory.Instance.BombItem());
            }
            else if(num == 2)
            {
                items.Add(position, ItemSpriteFactory.Instance.RupeeItem());
            }
            else if (num == 3)
            {
                items.Add(position, ItemSpriteFactory.Instance.HeartItem());
            }
            else
            {
                
            }
        }
    }
}
