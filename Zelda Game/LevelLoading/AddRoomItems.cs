using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class AddRoomItems
    {
        private static readonly AddRoomItems instance = new AddRoomItems();

        public static AddRoomItems Instance => instance;

        private AddRoomItems()
        {

        }

        public Dictionary<Vector2, IItem> LoadItems(Dictionary<Vector2, string> roomItems)
        {
            Dictionary<Vector2, IItem> itemList = new Dictionary<Vector2, IItem>();
            foreach (KeyValuePair<Vector2, string> item in roomItems)
            {
                if (item.Value.Equals("A")) itemList.Add(item.Key, ItemSpriteFactory.Instance.ArrowItem());

                else if (item.Value.Equals("BB")) itemList.Add(item.Key, ItemSpriteFactory.Instance.BombItem());

                else if (item.Value.Equals("B")) itemList.Add(item.Key, ItemSpriteFactory.Instance.BowItem());

                else if (item.Value.Equals("C")) itemList.Add(item.Key, ItemSpriteFactory.Instance.ClockItem());

                else if (item.Value.Equals("CM")) itemList.Add(item.Key, ItemSpriteFactory.Instance.CompassItem());

                else if (item.Value.Equals("F")) itemList.Add(item.Key, ItemSpriteFactory.Instance.FairyItem(item.Key));

                else if (item.Value.Equals("HC")) itemList.Add(item.Key, ItemSpriteFactory.Instance.HeartContainerItem());

                else if (item.Value.Equals("H")) itemList.Add(item.Key, ItemSpriteFactory.Instance.HeartItem());

                else if (item.Value.Equals("K")) itemList.Add(item.Key, ItemSpriteFactory.Instance.KeyItem());

                else if (item.Value.Equals("M")) itemList.Add(item.Key, ItemSpriteFactory.Instance.MapItem());

                else if (item.Value.Equals("R")) itemList.Add(item.Key, ItemSpriteFactory.Instance.RupeeItem());

                else if (item.Value.Equals("T")) itemList.Add(item.Key, ItemSpriteFactory.Instance.TriforcePieceItem());

                else if (item.Value.Equals("FI")) itemList.Add(item.Key, ItemSpriteFactory.Instance.Fire());
            }
            return itemList;
        }
    }
}