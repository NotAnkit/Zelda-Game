﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class ItemResponseLoop
    {
        public static List<Vector2> ItemLoop(Dictionary<Vector2, IItem> items, Link player, Dictionary<Vector2, IEnemy> enemies)
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
                    bool temp = player.soundManager.PlayItem;
                    if (item.Value is KeyItem)
                    {
                        player.inventory.Keys++;
                    }
                    else if (item.Value is MapItem)
                    {
                        player.inventory.CollectMap();
                    }
                    else if (item.Value is CompassItem)
                    {
                        player.inventory.CollectCompass();
                    }
                    else if (item.Value is RupeeItem)
                    {
                        player.inventory.Rupees++;
                    }
                    else if (item.Value is BombItem)
                    {
                        player.inventory.Bombs++;
                    }
                    else if (item.Value is FairyItem)
                    {
                        player.inventory.SetLives(5);
                    }
                    else if (item.Value is ClockItem)
                    {
                        foreach (KeyValuePair<Vector2, IEnemy> enemy in enemies)
                        {
                            enemy.Value.SetSpeed(0f);
                        }
                    }
                    else
                    {
                        player.inventory.AddItem(item.Value);
                    }

                    deleteItem.Add(item.Key);
                    
                }
            }

            return deleteItem;

        }
    }
}
