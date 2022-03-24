using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class ItemResponseLoop
    {
        public static Dictionary<Vector2, IItem> ItemLoop(Dictionary<Vector2, IItem> items, Link player)
        {
            string direction;
            List<Vector2> deleteItem = new List<Vector2>();
            foreach (KeyValuePair<Vector2, IItem> item in items)
            {
                Rectangle linkRectangle = player.LinkRectangle;
                Rectangle itemRectangle = item.Value.ItemRectangle();
                direction = CollisionDetection.GetDirection(linkRectangle, itemRectangle);
                if (direction != "none")
                {
                    deleteItem.Add(item.Key);
                    player.inventory.AddKey();
                }
            }

            foreach (Vector2 item in deleteItem)
            {
                items.Remove(item);
            }

            return items;

        }
    }
}
