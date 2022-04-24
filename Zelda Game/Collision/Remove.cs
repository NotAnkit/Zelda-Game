using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class Remove
    {
        public static void RemoveRoomObjects(List<Vector2> deleteEnemies, List<Vector2> deleteItems, Dictionary<Vector2, IEnemy> enemies, Dictionary<Vector2, IItem> items)
        {
            foreach (Vector2 enemy in deleteEnemies)
            {
                DropItem.EnemyDrop(items, enemy);
                enemies.Remove(enemy);
            }

            foreach (Vector2 item in deleteItems)
            {
                items.Remove(item);
            }
        }
    }
}
