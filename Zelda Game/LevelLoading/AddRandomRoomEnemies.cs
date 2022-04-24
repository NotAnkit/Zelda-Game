using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class AddRandomRoomEnemies
    {
        private static readonly AddRandomRoomEnemies instance = new AddRandomRoomEnemies();

        public static AddRandomRoomEnemies Instance => instance;

        private AddRandomRoomEnemies()
        {

        }

        public Dictionary<Vector2, IEnemy> LoadEnemies(Game1 game1)
        {
            Dictionary<Vector2, IEnemy> enemyList = new Dictionary<Vector2, IEnemy>();
            int value;
            Random r = new Random();
            int i = r.Next(1, 5);
            Vector2 location = new Vector2(59, 61);

            while (i > 0)
            {

                value = r.Next(1, 6);
                location.X = (r.Next(1, 10) * 32) + 59;
                location.Y = (r.Next(1, 6) * 32) + 61;

                if (!enemyList.ContainsKey(location))
                {

                    if (value == 1) enemyList.Add(location, new Jelly(game1, location));

                    else if (value == 2) enemyList.Add(location, new Bat(game1, location));

                    else if (value == 3) enemyList.Add(location, new Goriya(game1, location));

                    else if (value == 4) enemyList.Add(location, new Hand(game1, location));

                    else if (value == 5) enemyList.Add(location, new Stalfos(game1, location));

                    i--;
                }

            }

            return enemyList;
        }
    }
}