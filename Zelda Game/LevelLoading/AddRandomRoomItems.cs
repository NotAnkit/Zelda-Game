using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class AddRandomRoomItems
    {
        private static readonly AddRandomRoomItems instance = new AddRandomRoomItems();

        public static AddRandomRoomItems Instance => instance;

        private AddRandomRoomItems()
        {

        }

        public Dictionary<Vector2, IItem> LoadItems()
        {
            Dictionary<Vector2, IItem> itemList = new Dictionary<Vector2, IItem>();
            int value;
            Random r = new Random();
            int i = 1;
            Vector2 location = new Vector2(59, 61);

            while (i > 0)
            {

                value = r.Next(1, 4);
                location.X = (r.Next(1, 10) * 32) + 59;
                location.Y = (r.Next(1, 6) * 32) + 61;

                if (!itemList.ContainsKey(location))
                {

                    if (value == 1) itemList.Add(location, ItemSpriteFactory.Instance.RupeeItem());

                    else if (value == 2) itemList.Add(location, ItemSpriteFactory.Instance.HeartItem());

                    else if (value == 3) itemList.Add(location, ItemSpriteFactory.Instance.BombItem());

                    i--;
                }

            }

            return itemList;
        }
    }
}
