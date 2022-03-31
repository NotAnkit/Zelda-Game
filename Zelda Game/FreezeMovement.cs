using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class FreezeMovement
    {
        public static void unFreezeObjects(Dictionary<Vector2, IEnemy> enemies, Link player)
        {
            player.speed = 2;

            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemies)
            {
                enemy.Value.SetSpeed(1f);
            }
        }

        public static void freezeObjects(Dictionary<Vector2, IEnemy> enemies, Link player)
        {
            player.speed = 0;

            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemies)
            {
                enemy.Value.SetSpeed(0f);
            }

        }
    }
}
