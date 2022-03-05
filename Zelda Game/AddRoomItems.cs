using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class AddRoomItems
    {
        private static AddRoomItems instance = new AddRoomItems();

        public static AddRoomItems Instance
        {
            get
            {
                return instance;
            }
        }
        private AddRoomItems()
        {

        }

        public Dictionary<Vector2, IItem> LoadItems(Dictionary<Vector2, String> roomItems, Game1 game1)
        {
            Dictionary<Vector2, IItem> itemList = new Dictionary<Vector2, IItem>();
            foreach (KeyValuePair<Vector2, string> item in roomItems)
            {
                if (item.Value.Equals("A")) itemList.Add(item.Key, new ArrowItem(game1));

                else if (item.Value.Equals("BB")) itemList.Add(item.Key, new BombItem(game1));

                else if (item.Value.Equals("B")) itemList.Add(item.Key, new BowItem(game1));

                else if (item.Value.Equals("C")) itemList.Add(item.Key, new ClockItem(game1));

                else if (item.Value.Equals("CM")) itemList.Add(item.Key, new CompassItem(game1));

                else if (item.Value.Equals("F")) itemList.Add(item.Key, new FairyItem(game1));

                else if (item.Value.Equals("HC")) itemList.Add(item.Key, new HeartContainerItem(game1));

                else if (item.Value.Equals("H")) itemList.Add(item.Key, new HeartItem(game1));

                else if (item.Value.Equals("K")) itemList.Add(item.Key, new KeyItem(game1));

                else if (item.Value.Equals("M")) itemList.Add(item.Key, new MapItem(game1));

                else if (item.Value.Equals("R")) itemList.Add(item.Key, new RupeeItem(game1));

                else if (item.Value.Equals("T")) itemList.Add(item.Key, new TriforcePieceItem(game1));
            }
            return itemList;
        }
    }
}