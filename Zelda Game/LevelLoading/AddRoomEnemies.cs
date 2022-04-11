using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class AddRoomEnemies
    {
        private static readonly AddRoomEnemies instance = new AddRoomEnemies();

        public static AddRoomEnemies Instance => instance;
        private AddRoomEnemies()
        {

        }

        public Dictionary<Vector2, IEnemy> LoadEnemies(Dictionary<Vector2, string> roomEnemies, Game1 game1)
        {
            Dictionary<Vector2, IEnemy> enemyList = new Dictionary<Vector2, IEnemy>();
            foreach (KeyValuePair<Vector2, string> enemy in roomEnemies)
            {
                if (enemy.Value.Equals("J")) enemyList.Add(enemy.Key, new Jelly(game1, enemy.Key));

                else if (enemy.Value.Equals("B")) enemyList.Add(enemy.Key, new Bat(game1, enemy.Key));

                else if (enemy.Value.Equals("D")) enemyList.Add(enemy.Key, new Dragon(game1, enemy.Key));

                else if (enemy.Value.Equals("G")) enemyList.Add(enemy.Key, new Goriya(game1, enemy.Key));

                else if (enemy.Value.Equals("H")) enemyList.Add(enemy.Key, new Hand(game1, enemy.Key));

                else if (enemy.Value.Equals("S")) enemyList.Add(enemy.Key, new Stalfos(game1, enemy.Key));
            }
            return enemyList;
        }
    }
}
