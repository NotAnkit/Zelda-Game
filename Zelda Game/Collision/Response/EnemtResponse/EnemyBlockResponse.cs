using System.Collections.Generic;

namespace Zelda_Game
{
    public static class EnemyBlockResponse
    {
        public static void EnemyBlock(IEnemy enemy, string[] directionLocked, List<string> collisonDirection)
        {
            for (int i = 0; i < collisonDirection.Count; i++)
            {
                if (collisonDirection[i].Equals("top-bottom")) directionLocked[i] = "down";

                else if (collisonDirection[i].Equals("bottom-top")) directionLocked[i] = "up";

                else if (collisonDirection[i].Equals("right-left")) directionLocked[i] = "left";

                else directionLocked[i] = "right";
            }

            if (enemy.GetDirection() == directionLocked[0] || enemy.GetDirection() == directionLocked[1] || enemy.GetDirection() == directionLocked[2]) enemy.SetSpeed(0f);

            else enemy.SetSpeed(1f);
        }
    }
}
