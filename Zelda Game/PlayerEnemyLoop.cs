using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class PlayerEnemyLoop
    {
        public static void EnemyLoop(Dictionary<Vector2, IEnemy> enemies, Link player, Dictionary<Vector2, IEnvironment> blocks)
        {
            string direction;
            foreach (KeyValuePair<Vector2, IEnemy> enemy in enemies)
            {
                Rectangle linkRectangle = player.LinkRectangle;
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, enemyRectangle);
                //PlayerBlockLoop.BlockLoop(blocks, player);
                foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                {
                    PlayerEnemyResponse.PlayerEnemy(player, direction, block.Value);
                }
            }
        }
    }
}
